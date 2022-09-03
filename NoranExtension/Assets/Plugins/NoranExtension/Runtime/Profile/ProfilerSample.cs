using UniRx;
using Unity.Profiling;
using UnityEngine;

namespace Noran.Extension.Profile
{
    public class ProfilerSample : MonoBehaviour
    {
        private const string TEXTURE_MEMORY = "Texture Memory";
        private const string BATCHES_COUNT = "Batches Count";
        private NoranProfiler memoryProfiler;
        private NoranProfiler batchesProfiler;
        
        private void Start()
        {
            memoryProfiler = new NoranProfiler(ProfilerCategory.Memory, TEXTURE_MEMORY);
            batchesProfiler = new NoranProfiler(ProfilerCategory.Render, BATCHES_COUNT);

            Observable.EveryUpdate().Subscribe(_ =>
            {
                for (var i = 0; i < memoryProfiler.ProfilerRecorder.Count; i++)
                {
                    NoranExtension.DebugLog($"{TEXTURE_MEMORY}: {memoryProfiler.GetProfilerCount(i)}");
                }
                for (var i = 0; i < batchesProfiler.ProfilerRecorder.Count; i++)
                {
                    NoranExtension.DebugLog($"{BATCHES_COUNT}: {batchesProfiler.GetProfilerCount(i)}");
                }
            }).AddTo(gameObject);
        }

        private void OnDestroy()
        {
            memoryProfiler.Dispose();
            batchesProfiler.Dispose();
        }
    }
}
