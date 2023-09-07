using UnityEngine;

namespace TM
{
    [CreateAssetMenu(fileName = "Logger_New", menuName = "Logging/Logger")]
    public class Logging : ScriptableObject
    {
        [SerializeField]
        private bool showLogs = true;
        [SerializeField]
        private string prefix;
        [SerializeField]
        private Color prefixColor = new Color(0, 0, 0, 255);

        [SerializeField, HideInInspector]
        private string hexColor;
        
        public void Log(object message, Object sender)
        {
            if (showLogs)
            {
                Debug.Log($"<color={hexColor}>{prefix}: {message} | Sender: {sender.name}</color>", sender);
            }
        }

        public void Log(object message, object sender)
        {
            if (showLogs)
            {
                Debug.Log($"<color={hexColor}>{prefix}: {message} | Sender: {sender.GetType()}</color>");
            }
        }

        public void LogError(object message, Object sender)
        {
            if (showLogs)
            {
                Debug.LogError($"<color={hexColor}>{prefix} Error: {message} | Sender: {sender.name}</color>", sender);
            }
        }

        public void LogError(object message, object sender)
        {
            if (showLogs)
            {
                Debug.LogError($"<color={hexColor}>{prefix} Error: {message} | Sender: {sender.GetType()}</color>");
            }
        }

        public void LogWarning(object message, Object sender)
        {
            if (showLogs)
            {
                Debug.LogWarning($"<color={hexColor}>{prefix} Warning: {message} | Sender: {sender.name}</color>", sender);
            }
        }

        public void LogWarning(object message, object sender)
        {
            if (showLogs)
            {
                Debug.LogWarning($"<color={hexColor}>{prefix} Warning: {message} | Sender: {sender.GetType()}</color>");
            }
        }

        private void OnValidate()
        {
            hexColor = $"#{ColorUtility.ToHtmlStringRGBA(prefixColor)}";
        }
    }
}