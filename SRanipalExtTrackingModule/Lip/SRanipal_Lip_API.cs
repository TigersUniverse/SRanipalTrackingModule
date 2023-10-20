﻿//========= Copyright 2019, HTC Corporation. All rights reserved. ===========
using System.Runtime.InteropServices;

namespace ViveSR
{
    namespace anipal
    {
        namespace Lip
        {
            public static class SRanipal_Lip_API
            {
                /// <summary>
                /// Gets version 2 lip data from anipal's Lip module.
                /// </summary>
                /// <param name="data">ViveSR.anipal.Lip.LipData_v2</param>
                /// <returns>Indicates the resulting ViveSR.Error status of this method.</returns>
                [DllImport("SRanipal")]
                public static extern unsafe Error GetLipData_v2(ref LipData_v2 data);
            }
        }
    }
}