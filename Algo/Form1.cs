using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algo
{
    public partial class FormMain : Form
    {
        private List<int> _IntList = new List<int>();
        private Random _Random = new Random();
        public FormMain()
        {
            InitializeComponent();
        }

        private void GenerateList()
        {
            for (int i = i = 0; i < 20; i++)
            {
                _IntList.Add(RandomNumber(1, 1000));
            }
        }

        private int RandomNumber(int min, int max)
        {
            return _Random.Next(min, max);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateList();
            FillListBefore();
        }

        private void FillListBefore()
        {
            listBoxBefore.Items.Clear();
            foreach (var value in _IntList)
            {
                listBoxBefore.Items.Add(value.ToString());
            }
        }

        private void buttonTri_Click(object sender, EventArgs e)
        {
            SortedList();
        }

        private void SortedList()
        {
            List<int> _newList = new List<int>();
            int temp;
            for (int i = 1; i < _IntList.Count - 1; i++)
            {
                temp = _IntList[i-1];
                if (_IntList[i] > _IntList[i - 1])
                {
                    temp = _IntList[i - 1];
                    _newList.Add(temp);
                }
                else
                {
                    _newList.Add(_IntList[i]);
                }
            }
            listBoxAfter.Items.Clear();
            foreach (var value in _newList)
            {
                listBoxAfter.Items.Add(value.ToString());
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            labelResult.Text = factorielle(Convert.ToUInt64(textBoxValue.Text)).ToString();
        }

        private ulong factorielle(ulong valeur)
        {
            if (valeur == 1)
                return 1;
            else
                return valeur * factorielle(valeur - 1);
        }
    }
}
