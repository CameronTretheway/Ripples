// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
namespace MohawkGame2D
{
    public class Game
    {
        Ripple[] ripples = new Ripple[10];
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.ClearBackground(100, 100, 200);
            Window.SetTitle("Ripples");
        }
        public void Update()
        {

            if (Input.IsMouseButtonPressed(MouseButton.Left) == true);
            {
                    ripples[0].Update(Input.GetMouseX(), Input.GetMouseY(), 1); 

            }

        }
    }
}