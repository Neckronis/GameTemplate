using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Vestibule
{
    public static class InputManager
    {
        static KeyboardState kbState = Keyboard.GetState();
        static KeyboardState prevKBstate;
        static MouseState mouseState = Mouse.GetState();
        static MouseState prevMouseState;
        static bool isLeftMouseDown;
        static bool isRightMouseDown;
        static bool isLeftMouseUp;
        static bool isRightMouseUp;
        static bool isLeftMousePressed;
        static bool isRightMousePressed;
        static Vector2 mousePosition;
        static Vector2 prevMousePosition;
        static Vector2 mouseDirection;
        static float mouseDistanceTraveled;


        public static void Update()
        {
            prevKBstate = kbState;
            kbState = Keyboard.GetState();
            prevMouseState = mouseState;
            mouseState = Mouse.GetState();
            UpdateMouse();
        }

        static void UpdateMouse()
        {
            if (mouseState.LeftButton == ButtonState.Pressed)
                isLeftMouseDown = true;
            else
                isLeftMouseDown = false;
            if (mouseState.RightButton == ButtonState.Pressed)
                isRightMouseDown = true;
            else
                isRightMouseDown = false;

            if (mouseState.LeftButton == ButtonState.Released && prevMouseState.LeftButton == ButtonState.Pressed)
                isLeftMousePressed = true;
            else
                isLeftMousePressed = false;
            if (mouseState.RightButton == ButtonState.Released && prevMouseState.RightButton == ButtonState.Pressed)
                isRightMousePressed = true;
            else
                isRightMousePressed = false;

            if (mouseState.LeftButton == ButtonState.Released && prevMouseState.LeftButton == ButtonState.Released)
                isLeftMouseUp = true;
            else
                isLeftMouseUp = false;
            if (mouseState.RightButton == ButtonState.Released && prevMouseState.RightButton == ButtonState.Released)
                isRightMouseUp = true;
            else
                isRightMouseUp = false;

            prevMousePosition = mousePosition;
            mousePosition = new Vector2(mouseState.X, mouseState.Y);
            mouseDirection = Vector2.Normalize(mousePosition - prevMousePosition);
            //Distance between 2 points
            float dx = Math.Max(0, mousePosition.X - prevMousePosition.X);
            float dy = Math.Max(0, mousePosition.Y - prevMousePosition.Y);
            mouseDistanceTraveled = (float)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        public static bool IsKeyDown(Keys key)
        {
            if (kbState.IsKeyDown(key))
                return true;
            else
                return false;
        }

        public static bool IsKeyPressed(Keys key)
        {
            if (kbState.IsKeyDown(key) && prevKBstate.IsKeyUp(key))
                return true;
            else
                return false;
        }

        public static bool IsKeyReleased(Keys key)
        {
            if (kbState.IsKeyUp(key) && prevKBstate.IsKeyDown(key))
                return true;
            else
                return false;
        }

        public static Boolean IsLeftMouseDown
        {
            get { return isLeftMouseDown; }
        }

        public static Boolean IsRightMouseDown
        {
            get { return isRightMouseDown; }
        }

        public static Boolean IsLeftMouseUp
        {
            get { return isLeftMouseUp; }
        }

        public static Boolean IsRightMouseUp
        {
            get { return isRightMouseUp; }
        }

        public static Boolean IsLeftMousePressed
        {
            get { return isLeftMousePressed; }
        }

        public static Boolean IsRightMousePressed
        {
            get { return isRightMousePressed; }
        }

        public static Vector2 MousePosition
        {
            get { return mousePosition; }
        }

        public static Vector2 MouseDirection
        {
            get { return mouseDirection; }
        }

        public static float MouseDistanceTraveled
        {
            get { return mouseDistanceTraveled; }
        }
    }
}
