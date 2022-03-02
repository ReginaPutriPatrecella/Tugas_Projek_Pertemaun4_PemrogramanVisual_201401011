/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 02/03/2022
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_Projek_Pertemaun4_PemrogramanVisual_201401011
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
		void TekanClick(object sender, EventArgs e)
		{
			string nama = name.Text;
			int nom = int.Parse(nim.Text);
			string kom = kelas.Text;
			string matkul = kuliah.Text;
			
			MessageBox.Show ("Hello World " + nama + Environment.NewLine + "NIM : " + nom + Environment.NewLine + "KOM : " + kom + Environment.NewLine + "Mata Kuliah : " + matkul);
		}
	}
}
