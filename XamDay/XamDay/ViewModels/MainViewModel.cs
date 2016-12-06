using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamDay.ViewModels
{
   public class MainViewModel
    {
        public MainViewModel()
        {
            LoadMenu();
            LoadEvents();
        }

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<EventViewModel> Events { get; set; }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();


            Menu.Add(new MenuItemViewModel()
            {
                Icon = "agenda.png",
                Title = "Mi Agenda"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "estadisticas.png",
                Title = "Estadísticas"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "notificaciones.png",
                Title = "Notificaciones"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "configuracion.png",
                Title = "Configuración"
            });
        }

        private void LoadEvents()
        {
            Events = new ObservableCollection<EventViewModel>();

            Events.Add(new EventViewModel()
            {
                Date = "3",
                StartTime = "8:00 AM",
                EndTime = "5:00 PM"

            });

            Events.Add(new EventViewModel()
            {
                Date = "4",
                StartTime = "8:30 AM",
                EndTime = "5:00 PM"

            });

            Events.Add(new EventViewModel()
            {
                Date = "5",
                StartTime = "8:00 AM",
                EndTime = "5:00 PM"
            });

            Events.Add(new EventViewModel()
            {
                Date = "6",
                StartTime = "8:00 AM",
                EndTime = "6:00 PM"
            });

            Events.Add(new EventViewModel()
            {
                Date = "7",
                StartTime = "7:30 AM",
                EndTime = "5:30 PM"
            });
        }
    }
}
