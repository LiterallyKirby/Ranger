using OpenTK.Input;
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
using OpenTK.Input;
using System;


namespace Ranger
{
    internal partial class Game : GameWindow
    {
        float pitch;
        float yaw;
        private Vector2 lastMousePos;
        private bool firstMove = true;
        private float sensitivity = 0.1f;



        protected void HandleMouse()
        {


            var mouse = MouseState;

            if (firstMove)
            {
                lastMousePos = mouse.Position;
                firstMove = false;
            }
            else if (CursorState == CursorState.Grabbed)
            {
                var delta = mouse.Position - lastMousePos;
                lastMousePos = mouse.Position;

                yaw += delta.X * sensitivity;
                pitch -= delta.Y * sensitivity; // Invert Y if needed

                // Clamp pitch so you can't look too far up/down
                pitch = Math.Clamp(pitch, -89f, 89f);

                Console.WriteLine($"Yaw: {yaw}, Pitch: {pitch}");
            }
        }


        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            MouseState input = MouseState;
            if (e.Button == MouseButton.Left)
            {
                Console.WriteLine("Left click");
                CursorState = CursorState.Grabbed;
            }
            else if (e.Button == MouseButton.Right)
            {
                Console.WriteLine("Right click at: " + input.Position);
                // Right click action
            }
        }
    }
}
