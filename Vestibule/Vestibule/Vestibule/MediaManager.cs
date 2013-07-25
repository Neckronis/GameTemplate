using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework;

namespace Vestibule
{
    public static class MediaManager
    {
        static ContentManager content;
        static Dictionary<string, Texture2D> imageCollection = new Dictionary<string, Texture2D>();
        static Dictionary<string, SpriteFont> spriteFontCollection = new Dictionary<string, SpriteFont>();
        static Dictionary<string, SoundEffect> soundEffectCollection = new Dictionary<string, SoundEffect>();
        static Dictionary<string, Song> songCollection = new Dictionary<string, Song>();

        public static void Initialize(ContentManager contentManager)
        {
            content = contentManager;
        }

        public static Texture2D GetTexture2D(string name)
        {
            if (imageCollection.ContainsKey(name))
                return imageCollection[name];
            else
            {
                string path = "Textures/";
                Texture2D texture = content.Load<Texture2D>(path + name);
                if (texture != null)
                    imageCollection.Add(name, texture);
                return texture;
            }
        }

        public static SpriteFont GetSpriteFont(string name)
        {
            if (spriteFontCollection.ContainsKey(name))
                return spriteFontCollection[name];
            else
            {
                string path = "Fonts/";
                SpriteFont spriteFont = content.Load<SpriteFont>(path + name);
                if (spriteFont != null)
                    spriteFontCollection.Add(name, spriteFont);
                return spriteFont;
            }
        }

        public static SoundEffect GetSoundEffect(string name)
        {
            if (soundEffectCollection.ContainsKey(name))
                return soundEffectCollection[name];
            else
            {
                string path = "SoundEffects/";
                SoundEffect soundEffect = content.Load<SoundEffect>(path + name);
                if (soundEffect != null)
                    soundEffectCollection.Add(name, soundEffect);
                return soundEffect;
            }
        }

        public static Song GetSong(string name)
        {
            if (songCollection.ContainsKey(name))
                return songCollection[name];
            else
            {
                string path = "Songs/";
                Song song = content.Load<Song>(path + name);
                if (song != null)
                    songCollection.Add(name, song);
                return song;
            }
        }
    }
}
