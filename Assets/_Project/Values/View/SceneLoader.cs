using Core.Values;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace View.Values
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private SceneValue _scene;

        public void Load()
        {
            SceneManager.LoadScene(_scene.Value);
        }
    }
}