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



namespace Ranger
{
    internal partial class Game : GameWindow
    {
        protected void HandleKeyboard(FrameEventArgs e)
        {
            if (!IsFocused) // check to see if the window is focused
            {
                return;
            }

            KeyboardState input = KeyboardState;


            if (input.IsKeyDown(Keys.W))
            {
                cameraPos += cameraFront * cameraSpeed * (float)e.Time; //Forward 
            }

            if (input.IsKeyDown(Keys.S))
            {
                cameraPos -= cameraFront * cameraSpeed * (float)e.Time; //Backwards
            }

            if (input.IsKeyDown(Keys.A))
            {
                cameraPos -= Vector3.Normalize(Vector3.Cross(cameraFront, cameraUp)) * cameraSpeed * (float)e.Time; //Left
            }

            if (input.IsKeyDown(Keys.D))
            {
                cameraPos += Vector3.Normalize(Vector3.Cross(cameraFront, cameraUp)) * cameraSpeed * (float)e.Time; //Right
            }

            if (input.IsKeyDown(Keys.Space))
            {
                cameraPos += cameraUp * cameraSpeed * (float)e.Time; //Up 
            }

            if (input.IsKeyDown(Keys.LeftShift))
            {
                cameraPos -= cameraUp * cameraSpeed * (float)e.Time; //Down
            }

            if (input.WasKeyDown(Keys.Escape))
            {
                CursorState = CursorState.Normal;
            }
        }
    }
}
