using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL4;
using System.Threading.Tasks;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Ranger
{
    internal partial class Game : GameWindow
    {
        private static Vector3 cameraPos = new Vector3(0.0f, 0.0f, 3.0f);
        private static Vector3 cameraTarget = Vector3.Zero;
        private static Vector3 cameraFront = -Vector3.UnitZ; // Camera looks along the -Z axis
        private static Vector3 cameraUp = Vector3.UnitY;
        private static Vector3 cameraRight = Vector3.Normalize(Vector3.Cross(cameraUp, cameraFront));
        private static float cameraSpeed = 2.5f;
        private Matrix4 cameraView;

        Matrix4 model = Matrix4.Identity;
        Matrix4 projection;




    }
}
