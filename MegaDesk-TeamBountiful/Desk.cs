using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_TeamBountiful
{
    public enum DesktopMaterial
    {
        Laminate = 100, 
        Oak = 200, 
        Rosewood = 300, 
        Veneer = 125, 
        Pine = 50
    }
        
    public class Desk
    {
        public const int MAXWIDTH = 96;
        public const int MINWIDTH = 24;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 12;

        private int width = 0;
        public int Width {
            get => width;
            set 
            { 
                width = value;
                area = GetArea();
            }
        }

        private int depth = 0;
        public int Depth
        {
            get => depth;
            set 
            { 
                depth = value;
                area = GetArea();
            }
        }

        public int Drawers { get; set; } = 0;

        public DesktopMaterial SurfaceMaterial { get; set; }

        public Desk(int width, int depth, int drawers, DesktopMaterial surfaceMaterial)
        {
            Width = width;
            Depth = depth;
            Drawers = drawers;
            SurfaceMaterial = surfaceMaterial;
        }

        private int area;
        public int Area
        {
            get => area;
            set => area = GetArea();
        }

        private bool ValidateDeskDimensions()
        {
            return (width >= MINWIDTH)
                & (width <= MAXWIDTH)
                & (depth >= MINDEPTH)
                & (depth <= MAXDEPTH);
        }

        private int GetArea()
        {
            return ValidateDeskDimensions() ? width * depth : 0;
        }
    }
}
