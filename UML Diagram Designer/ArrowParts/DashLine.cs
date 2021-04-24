﻿using System.Drawing.Drawing2D;

namespace UML_Diagram_Designer.ArrowParts
{
    public class DashLine : AbstractLine
    {
        public DashLine()
        {
            _lineStyle = DashStyle.Dash;

            GetLine(_lineStyle);
        }
    }
}
