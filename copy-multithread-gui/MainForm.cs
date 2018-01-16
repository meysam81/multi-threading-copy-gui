/*
 * Created by SharpDevelop.
 * User: Meysam
 * Date: 1/16/2018
 * Time: 08:31
 * 
 */
using System;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace copy_multithread_gui
{
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ButtonStartClick(object sender, EventArgs e)
		{
			Copy c = null;
			if (textBoxSrc.Text != "" && textBoxDest.Text != "")
			{
				c = new Copy(textBoxSrc.Text, textBoxDest.Text);
				if (textBoxNThrd.Text != "")
				{
					try
					{
						int count = Convert.ToInt32(textBoxNThrd.Text);
						c.startFunc(count); // starts the function
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.StackTrace + "\r\n" + ex.Message);
					}
				}
			}
			
		}
		void ButtonExit(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
	class Copy
	{
		// a lock mechanism to avoid race condition i.e. collisions of threads for shared resource
		static Semaphore readSemaphore = new Semaphore(1, 1),
		writeSemaphore = new Semaphore(1, 1);
		
		static int srcHead = 0; // source file head location
		string sourceLocation, destLocation; // location of source and destination file
		public Copy(string srcLoc, string destLoc) // constructor used for initializing threads
		{
			this.sourceLocation = srcLoc;
			this.destLocation = destLoc;
		}
		public void startFunc(int numberOfThreads)
		{
			try
			{
				int N = // number of threads
					numberOfThreads;
				Thread[] t = new Thread[N];
				Copy[] pr = new Copy[N];
				for (int i = 0; i < N; i++)
				{
					pr[i] = new Copy(sourceLocation, destLocation);
					t[i] = new Thread(new ThreadStart(pr[i].thrdFunc));
					t[i].Name = (i + 1).ToString();
				}
				for (int i = 0; i < N; i++)
					t[i].Start(); // multithreding starts from here
				MessageBox.Show("Done");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace + "\r\n" + ex.Message);
			}
		}
		public void thrdFunc()
		{
			while (true) {
				try {
					
					string tmp = null;
					
					readSemaphore.WaitOne(); // get the lock
					
					// read srcHead'th line
					tmp = File.ReadLines(sourceLocation).Skip(srcHead).FirstOrDefault();
					
					// increase srchead for next read from source
					srcHead += 1;
					
					readSemaphore.Release(); // release the lock
					
					if (tmp == null) // nothing to read i.e. end of file; so no need to write
					{
						break;
					}
					
					writeSemaphore.WaitOne();
					using (StreamWriter sw = new StreamWriter(destLocation, true))
					{
						sw.WriteLine(tmp);
					}
					writeSemaphore.Release();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.StackTrace + "\r\n" + ex.Message);
				}
			}
		}
	}
}
