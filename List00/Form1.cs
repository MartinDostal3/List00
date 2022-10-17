using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //****************************************
        //Vytvoření instance seznamfilmu třídy List
        //List bude obsahovat řetězce
        
        List<string> seznamfilmu = new List<string>();    //Vytvořili jsme prázdný list řetězců, do seznamu budeme ukládat názvy filmů

        //*****************************************

        private void button1_Click(object sender, EventArgs e)
        {
            //Metoda Add
            //(Jako řetězec zadejte název filmu)
            seznamfilmu.Add("aa");
            seznamfilmu.Add("bbaa");
            seznamfilmu.Add("ccaa");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Počet prvků v kolekci - metoda Count

            listBox1.Items.Clear();
            // *** cyklem foreach ***
            

            // *** cyklem for - přes indexy ***
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //metoda Remove - odstraní první nalezený řetězec
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Clear
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RemoveAt()
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Contains
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //IndexOf
           
            //Pokud prvek v seznamu není, vrací metoda IndexOf() hodnotu -1
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //LastIndexOf
            
            //Pokud prvek není v List obsažen, vrátí index -1
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Distinct
            //Vrátí List s odlišnými prvky
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Insert
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Count
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //index píšene stejně jako u pole v hranatých závorkách
            //1. prvek má index 0
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Sort
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Reverse
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //AddRange
            List<string> novySeznam = seznamfilmu.Take(2).ToList();
            foreach (string film in novySeznam) MessageBox.Show(film);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string[] poleFilmu = new string[seznamfilmu.Count];
            seznamfilmu.CopyTo(poleFilmu);
            foreach (string film in poleFilmu) MessageBox.Show(film);
        }
    }
}
