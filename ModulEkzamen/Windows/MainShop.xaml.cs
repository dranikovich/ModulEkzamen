using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Data.Entity.Migrations;

namespace ModulEkzamen.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainShop.xaml
    /// </summary>
    public partial class MainShop : Page
    {
        List<Книги> Books = Classes.Base.BDD.Книги.ToList();
        string CuPat = Environment.CurrentDirectory;
        int i = 0;
        public MainShop()
        {
            InitializeComponent();
            DGServises.ItemsSource = Books;
        }

        private void StackPanel_Initialized_1(object sender, EventArgs e)
        {
            
            if (i < Books.Count)
            {
                i++;
            }
        }

        private void BookTitle_Initialized(object sender, EventArgs e)
        {
            if (i < Books.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги S = Books[i];
                TB.Text = "Название: " + S.Название;
            }
        }

        private void BookAuthor_Initialized(object sender, EventArgs e)
        {
            if (i < Books.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги S = Books[i];
                string OPat ="Автор: " + Convert.ToString(S.Автор);
                TB.Text =  OPat;
            }
        }

        private void BookPrice_Initialized(object sender, EventArgs e)
        {
            if (i < Books.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги S = Books[i];
                TB.Text = "цена: " +Convert.ToString(S.Цена);

            }
        }

        private void BookCountInShop_Initialized(object sender, EventArgs e)
        {
            if (i < Books.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги S = Books[i];
                TB.Text = "Наличие в магазине: " + Convert.ToString(S.Количество_магазин);

            }
        }

        private void BookCountOnReserve_Initialized(object sender, EventArgs e)
        {
            if (i < Books.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги S = Books[i];
                TB.Text = Convert.ToString(S.Количество_склад);

                if (S.Количество_склад > 5)
                {
                    TB.Text = "Наличие на складе: " + "Много";
                }
            }
        }

        private void MediaElement_Initialized(object sender, EventArgs e)
        {
            if (i < Books.Count)
            {
                MediaElement ME = (MediaElement)sender;
                Книги S = Books[i];
                string OPat = CuPat.Substring(0, CuPat.Length - 9) + S.Обложка;
                Uri U = new Uri(OPat, UriKind.RelativeOrAbsolute);
                ME.Source = U;
            }
        }

        private void BAdd_Initialized(object sender, EventArgs e)
        {
            Button BAdd = (Button)sender;
            if (BAdd != null)
            {
                BAdd.Uid = Convert.ToString(i);
            }
        }
        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Button BAdd = (Button)sender;
            int ind = Convert.ToInt32(BAdd.Uid);
            Книги S = Books[ind];
            int x = Convert.ToInt32(CartCount.Text);
            CartCount.Text = (Convert.ToInt32(CartCount.Text) + 1) + "";
            CartPrice.Text = Classes.Pricer.Price1(x, S.Цена);
            int dis = Convert.ToInt32(Classes.Pricer.Discount(Convert.ToInt32(CartCount.Text), Convert.ToInt32(CartPrice.Text)));
            CartDiscount.Text = Convert.ToString(dis);
            CartPriceDiscount.Text = " " + (Convert.ToInt32(Classes.Pricer.Price1(x, S.Цена)) -  (Convert.ToInt32(Classes.Pricer.Price1(x, S.Цена)) / 100 * Convert.ToInt32(Classes.Pricer.Discount(Convert.ToInt32(CartCount.Text), Convert.ToInt32(CartPrice.Text))))) + "";
        }
    }
}