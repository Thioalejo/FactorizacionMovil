using System;
using System.Collections.Generic;
using System.Text;

namespace Factorizacion.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Factorizacion
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
