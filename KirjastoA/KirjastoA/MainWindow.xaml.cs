﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KirjastoA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Tämä muuttuja pitää tietoa käyttäjän valitsemasta kirjastosta
        private Kirjasto valittuKirjasto;

        public MainWindow()
        {
            valittuKirjasto = new Kirjasto(
                "palosaaen kirjasto",
                "Pikitehtaankati 19, 65200 Vaasa"
                );
            valittuKirjasto.LuoMockDataa(30);

            InitializeComponent();
            //Kerrotaan ListView-komponentille, että sen pitää näyttää
            //valittuKirjasto.Teokset listaa sen sisällä
            //Listview.ItemsSource kertoo, mikä on itemeiden "lähde"
            // Jokainen item näytetään rivinä ListView:n sisällä
            dataGrid.ItemsSource = valittuKirjasto.Teokset;
        }
    }
}
