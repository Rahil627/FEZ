﻿// Type: OpenTK.Platform.X11.XColor
// Assembly: OpenTK, Version=1.1.0.0, Culture=neutral, PublicKeyToken=bad199fe84eb3df4
// MVID: FE2CFFE8-B942-430E-8C15-E783DB6F0AD6
// Assembly location: F:\Program Files (x86)\FEZ\OpenTK.dll

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  internal struct XColor
  {
    public IntPtr pixel;
    public ushort red;
    public ushort green;
    public ushort blue;
    public byte flags;
    public byte pad;
  }
}
