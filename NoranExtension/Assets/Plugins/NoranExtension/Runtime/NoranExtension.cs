using System;
using System.Diagnostics;
using Noran.Extension.Debugger;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace Noran.Extension
{
    /// <summary>
    /// UNITYの基本的な機能をまとめる
    /// </summary>
    public partial struct NoranExtension
    {
        /// <summary>
        /// Editor上でのみDebug.Logを吐き出すシンプルなメソッド
        /// </summary>
        /// <param name="message"></param>
        [Conditional("UNITY_EDITOR")]
        public static void DebugLog(string message)
        {
            if (!UseDebugExtension()) return;
            Debug.Log(message);
        }
        
        /// <summary>
        /// Editor上でのみオブジェクトの名前をDebug.Logに吐き出す
        /// </summary>
        /// <param name="target"></param>
        /// <typeparam name="T"></typeparam>
        [Conditional("UNITY_EDITOR")]
        public static void DebugLogObjectName<T>(T target) where T : Object
        {
            if (!UseDebugExtension()) return;
            Debug.Log($"[ObjectName]: {target.name}");
        }

        /// <summary>
        /// Editor上でのみメソッドの名前をDebug.Logに吐き出す
        /// </summary>
        /// <param name="action"></param>
        [Conditional("UNITY_EDITOR")]
        public static void DebugLogActionName(Action action)
        {
            if (!UseDebugExtension()) return;
            Debug.Log($"[ActionName]: {action.Method.Name}");
            action();
        }

        private static UseDebugScriptableObject debugEx;

        private static bool UseDebugExtension()
        {
            debugEx ??= Resources.Load<UseDebugScriptableObject>("UseDebugExtension");
            return debugEx.UseDebugExtension;
        }
    }
}
