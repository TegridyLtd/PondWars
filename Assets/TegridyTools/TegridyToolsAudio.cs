/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using System.Collections;
using UnityEngine;
using System;
namespace Tegridy.Tools 
{
    public class AudioTools
    {
        public static void PlayClip(AudioClip clip, AudioSource source)
        {
            if (source.isPlaying == false)
            {
                source.clip = clip;
                source.Play();
            }
        }
        public static void PlayRandomClip(AudioClip[] clip, AudioSource source)
        {
            if (clip.Length > 0 && source.isPlaying == false)
            {
                source.clip = clip[UnityEngine.Random.Range(0, clip.Length)];
                source.Play();
            }
        }
        public static void PlayRandomClipAnyway(AudioClip[] clip, AudioSource source)
        {
            if (clip.Length > 0)
            {
                source.clip = clip[UnityEngine.Random.Range(0, clip.Length)];
                source.Play();
            }
        }
        public static void PlayOneShot(AudioClip[] clip, AudioSource source)
        {
            if (clip.Length > 0)
            {
                source.PlayOneShot(clip[UnityEngine.Random.Range(0, clip.Length)]);
            }
        }
        public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
        {
            float startVolume = audioSource.volume;
            while (audioSource.volume > 0)
            {
                audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
                yield return null;
            }
        }
        public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
        {
            float startVolume = 0.2f;
            while (audioSource.volume < 1.0f)
            {
                audioSource.volume += startVolume * Time.deltaTime / FadeTime;
                yield return null;
            }
        }

        public static float FadeOnInput(AudioSource source, float current, float previous, float tolerance, float speed)
        {
            float _check = Math.Abs(current - previous);
            float _audioVol = source.volume;

            if (_check > tolerance) _audioVol += Time.deltaTime * speed;
            else _audioVol -= Time.deltaTime * speed;

            _audioVol = Mathf.Clamp(_audioVol, 0, 1);

            source.volume = _audioVol;
            return current;
        }
    }
}
