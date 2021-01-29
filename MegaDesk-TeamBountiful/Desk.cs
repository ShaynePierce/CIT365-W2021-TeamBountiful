using System;

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

        private int _width = 0;
        public int Width {
            get => _width;
            set 
            { 
                _width = value;
                area = GetArea();
            }
        }

        private int _depth = 0;
        public int Depth
        {
            get => _depth;
            set 
            { 
                _depth = value;
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
            return (_width >= MINWIDTH)
                & (_width <= MAXWIDTH)
                & (_depth >= MINDEPTH)
                & (_depth <= MAXDEPTH);
        }

        private int GetArea()
        {
            return ValidateDeskDimensions() ? _width * _depth : 0;
        }
    }
}
