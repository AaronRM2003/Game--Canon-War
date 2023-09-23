using UnityEngine;
using UnityEngine.Advertisements;
public class ads : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener
{
    [SerializeField] string _androidGameId = "5331398";
    [SerializeField] string _iOSGameId = "5331399";
    [SerializeField] bool _testMode = false;
    private string _gameId;
    [SerializeField] string _androidAdUnitId = "Interstitial_Android";
    [SerializeField] string _iOsAdUnitId = "Interstitial_iOS";
    public string _adUnitId;
    void Awake()
    {
        InitializeAds();
    }

    public void InitializeAds()
    {
#if UNITY_IOS
            _gameId = _iOSGameId;
#elif UNITY_ANDROID
            _gameId = _androidGameId;
#elif UNITY_EDITOR
            _gameId = _androidGameId; //Only for testing the functionality in the Editor
#endif
        _adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
         ? _iOsAdUnitId
         : _androidAdUnitId;
        if (Advertisement.isSupported)
        {
            if (!Advertisement.isInitialized)
            {
                Advertisement.Initialize(_gameId, _testMode, this);
            }
            else
            {
                Advertisement.Load(_adUnitId, this);
            }
        }
    }

    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        Debug.Log("Loaded Ad: " + _adUnitId);

        // Optionally execute code if the Ad Unit successfully loads content.
    }

    public void OnUnityAdsFailedToLoad(string _adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit: {_adUnitId} - {error.ToString()} - {message}");
        // Optionally execute code if the Ad Unit fails to load, such as attempting to try again.
    }
    public void OnInitializationComplete()
    {
        Advertisement.Load(_adUnitId, this);
    }
    public void LoadAd()
    {
        // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
        Debug.Log("Loading Ad: " + _adUnitId);
        Advertisement.Load(_adUnitId, this);
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
}