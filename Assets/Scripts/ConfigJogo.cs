using UnityEngine;

public class ConfigJogo : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
