﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshTiler.Lib
{
    public class Extent
    {
        public double XMax { get; set; }
        public double XMin { get; set; }
        public double YMax { get; set; }
        public double YMin { get; set; }
        public double ZMax { get; set; }
        public double ZMin { get; set; }

        public double XSize { get { return XMax - XMin; }}
        public double YSize { get { return YMax - YMin; } }
        public double ZSize { get { return ZMax - ZMin; } }

        public Vector3D MaxCorner { get { return new Vector3D(XMax, YMax, ZMax); } }
        public Vector3D MinCorner { get { return new Vector3D(XMin, YMin, ZMin); } }


    }
}
