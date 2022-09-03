using System;
using Unity.Profiling;

namespace Noran.Extension.Profile
{
    public class NoranProfiler : IDisposable
    {
        public ProfilerRecorder ProfilerRecorder { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="category"></param>
        /// <param name="statName"></param>
        public NoranProfiler(ProfilerCategory category, string statName)
        {
            ProfilerRecorder = ProfilerRecorder.StartNew(category, statName);
        }

        /// <summary>
        /// Profilerの数値（long）を返す
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public long GetProfilerCount(int index)
        {
            return ProfilerRecorder.GetSample(index).Value;
        }

        /// <summary>
        /// 破棄の処理
        /// </summary>
        public void Dispose()
        {
            ProfilerRecorder.Dispose();
        }
    }
}
