using System;
using UnityEngine;

namespace Scripts.Audio
{
    public class AudioManager : MonoBehaviour
    {
        private static AudioManager _ins;
        public static AudioManager Ins
        {
            get
            {
                if (_ins == null)
                    _ins = FindObjectOfType<AudioManager>();

                return _ins;
            }
        }

        public Sound[] musicSounds;
        public Sound[] sfxSounds;

        public AudioSource musicSource;
        public AudioSource sfxSource;

        public void PlayMusic(string name)
        {
            Sound s = Array.Find(musicSounds, x => x.name == name);

            if (s == null)
                print("Sound Not Found");

            else
            {
                musicSource.clip = s.clip;
                musicSource.Play();
            }
        }

        public void StopMusic()
        {
            musicSource.Stop();
        }

        public void PlaySFX(string name)
        {
            Sound s = Array.Find(sfxSounds, x => x.name == name);

            if (s == null)
                print("Sound Not Found");

            else
            {
                sfxSource.clip = s.clip;
                sfxSource.Play();
            }
        }

        public void StopSFX()
        {
            sfxSource.Stop();
        }

        public void StopAllSounds()
        {
            musicSource.Stop();
            sfxSource.Stop();
        }

        public void SetMusicVolume(float volume)
        {
            musicSource.volume = volume;
        }

        public void SetSFXVolume(float volume)
        {
            sfxSource.volume = volume;
        }

        public void SetMusicLoop(bool loop)
        {
            musicSource.loop = loop;
        }

        public void SetSFXLoop(bool loop)
        {
            sfxSource.loop = loop;
        }

        public void PlayMusicOnce(string name)
        {
            Sound s = Array.Find(musicSounds, x => x.name == name);

            if (s == null)
                print("Sound Not Found");

            else
            {
                musicSource.clip = s.clip;
                musicSource.PlayOneShot(musicSource.clip);
            }
        }

        public void PlaySFXOnce(string name)
        {
            Sound s = Array.Find(sfxSounds, x => x.name == name);

            if (s == null)
                print("Sound Not Found");

            else
            {
                sfxSource.clip = s.clip;
                sfxSource.PlayOneShot(sfxSource.clip);
            }
        }
    }
}

