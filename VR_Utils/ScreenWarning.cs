using OghiUnityTools.Utils.Timer;
using OghiUnityTools.Utils.Timer.Timers;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace OghiVrTools.VR_Utils
{
    public class ScreenWarning : MonoBehaviour
    {
        public float WarningTime = 4f;

        [SerializeField] private Volume postProcessVolume;

        private Vignette vignette;

        private Timer warningTimer;

        private bool warningUser;

        private void Awake()
        {
            warningTimer = new CountdownTimer(WarningTime);
            warningTimer.OnTimerStop += StopWarningUser;
        }

        private void Start()
        {
            if (!postProcessVolume)
            {
                Debug.LogError("PostProcessing Volume not assigned");
                return;
            }

            postProcessVolume.profile.TryGet(out vignette);
            if (!vignette) Debug.LogWarning("Vignette component not found on the post processing volume");

            vignette.color.value = Color.red;
            vignette.rounded.value = true;
            vignette.intensity.value = 0f;

            WarnUser();
        }

        private void Update()
        {
            warningTimer.Tick();
        }

        private void OnDestroy()
        {
            warningTimer.OnTimerStop -= StopWarningUser;
        }

        public void WarnUser()
        {
            if (warningUser) return;

            vignette.intensity.value = 1f;

            warningTimer.Start();
        }

        private void StopWarningUser()
        {
            vignette.intensity.value = 0f;
            warningUser = false;
        }
    }
}