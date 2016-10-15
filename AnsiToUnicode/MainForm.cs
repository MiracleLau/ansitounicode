/*
 * Created by SharpDevelop.
 * User: Radiation
 * Date: 2016/10/13
 * Time: 18:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace AnsiToUnicode
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://b.zlweb.cc");
		}
		void Button1Click(object sender, EventArgs e)
		{
			string con = textBox1.Text.Trim();
			if(con=="")
			{
				MessageBox.Show("请输入要解码的字符!");
			}else{
				try{
					System.Text.UnicodeEncoding uncode = new System.Text.UnicodeEncoding();
					byte[] enstr = uncode.GetBytes(con);
					string hexstr="";
					int i=1;
					int len = enstr.Length;
					foreach (byte letter in enstr)
					{
						int value = Convert.ToInt32(letter);
						if(i==len)
						{
							hexstr+=String.Format("{0:X}",value);
						}else{
							hexstr+=String.Format("{0:X}",value)+" ";
						}
						i++;
					}
					//MessageBox.Show(hexstr);
					string[] hexvalue = hexstr.Split(' ');
					string mstr="";
					//char charValue;
					foreach(String hex in hexvalue)
					{
						int value = Convert.ToInt32(hex,16);
						mstr += Char.ConvertFromUtf32(value);
						//charValue+=
					}
					textBox2.Text=mstr;
				}
				catch(Exception ex)
				{
					MessageBox.Show("发生异常错误!"+ex.Message);
				}
				
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("本程序可以用来解密类似于`┼攠數畣整爠煥敵瑳∨卆攰獡㍙猲ㅴ⤢㸥`的asp一句话木马乱码，由于在一些ctf题目中" +
			                "经常出现这样的题目，而每次解码都要也稍微有些麻烦，所以就直接写了个这样的小工具，节省时间，提高效率.");
		}
	}
}
