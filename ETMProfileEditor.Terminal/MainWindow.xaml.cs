﻿using System.Windows;
using Unity;

namespace ETMProfileEditor.Terminal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [Dependency]
        public Terminal.MainViewModel ViewModel
        {
            private get => this.DataContext as MainViewModel;
            set => this.DataContext = value;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        //HashSet<object> dict = new HashSet<object>(new EqComparer());

        private void MasterView_CollectionChange(object sender, View.CollectionChangeEventArgs e)
        {
            //foreach (var x in e.Dictionary)
            //{
            //}

            ViewModel.RepositoryViewModel.SelectedContentChangedCommand.Execute(e.Dictionary);
        }

        //private void CheckAll()
        //{
        //    foreach(var x in dict.Cast<ViewModel.Step>())
        //    {
        //    }
        //}

        //class EqComparer : IEqualityComparer<object>
        //{
        //    public new bool Equals([AllowNull] object x, [AllowNull] object y)
        //    {
        //        return (x as ViewModel.Step).Description == (y as ViewModel.Step).Description;
        //    }

        //    public int GetHashCode([DisallowNull] object obj)
        //    {
        //        return (obj as ViewModel.Step).Description.Length;
        //    }
        //}
    }
}