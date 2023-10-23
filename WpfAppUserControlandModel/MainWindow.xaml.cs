using System;
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
using WpfAppUserControlandModel.Models;
using WpfAppUserControlandModel.ViewModels;

namespace WpfAppUserControlandModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MusicPlayerViewModel vm;
        public List<Song> songs = new List<Song>();

        public MainWindow()
        {
            InitializeComponent();
            songs.Add(new Song("Wake Me When September Ends", 4.45f));
            songs.Add(new Song("No Sleep Till Brooklyn", 4.06f));
            songs.Add(new Song("GODS", 3.41f));
            vm = new MusicPlayerViewModel(new MusicPlayer(songs));
            this.DataContext = vm;
        }
    }
}
