using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_TeamBountiful
{
    public enum DesktopMaterial
    {
        Laminate, 
        Oak, 
        Rosewood, 
        Veneer, 
        Pine
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
            get { return width; }
            set 
            { 
                width = value;
                area = GetArea();
            }
        }

        private int depth = 0;
        public int Depth
        {
            get { return depth; }
            set 
            { 
                depth = value;
                area = GetArea();
            }
        }

        private int drawers = 0;
        public int Drawers
        {
            get { return drawers; }
            set { drawers = value; }
        }

        private string surfaceMaterial;
        public string SurfaceMaterial
        {
            get { return surfaceMaterial; }
            set { surfaceMaterial = value; }
        }


        public Desk(int width, int depth, int drawers, string surfaceMaterial)
        {
            Width = width;
            Depth = depth;
            Drawers = drawers;
            SurfaceMaterial = surfaceMaterial ?? throw new ArgumentNullException(nameof(surfaceMaterial));
        }

        private int area;
        public int Area
        {
            get { return area; }
            set { area = GetArea(); }
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
