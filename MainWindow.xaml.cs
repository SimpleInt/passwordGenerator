using PassWordGenerator.password;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PassWordGenerator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		
		public MainWindow()
		{			
		InitializeComponent();			
		}


		string finalPassword = "";
		public void btnReadConfig_Click(object sender, RoutedEventArgs e)
		{
			uint a;
			uint b = 100000;
			try
			{
				a = uint.Parse(txtLENGHT.Text);
				if (a > b) throw new OverflowException();
				
			}
			catch (Exception ex) 
			{
				if (ex.GetType() == typeof(OverflowException))
				{
					MessageBox.Show("El numero es mayor a "+ b, "¡Numero demasiado grande!");
				}
				else
				{
					MessageBox.Show("" + ex);
				}
				a = 0;
			}
			finalPassword = @params.param((bool)checkSym.IsChecked, (bool)checkNums.IsChecked, (bool)checkLow.IsChecked, (bool)checkUpp.IsChecked, (bool)checkAmb.IsChecked, (bool)checkPer.IsChecked, a);
			textBox.Text = finalPassword;	
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			if (passwordBox.Password == finalPassword)
			{
				checkPS.Content = "true";
			}
			else
			{
				checkPS.Content = "false";
			}
		}	

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			Clipboard.SetText(finalPassword);
		}

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
