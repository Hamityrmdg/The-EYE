using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour
{
    public string GameID = "GAME_ID";
    public string BannerPlacementID = "Banner";
    public bool testModu = true;

    private bool bannerG�sterilecek = true;
    
    void Start()
    {
        Advertisement.Initialize(GameID, testModu);
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        BannerGoster();
    }

    
    void Update()
    {
        if (bannerG�sterilecek)
        {
            if (Advertisement.IsReady(BannerPlacementID))
            {
                Advertisement.Banner.Show(BannerPlacementID);
                bannerG�sterilecek=false;   
            }
        }
    }
    public void BannerGoster()
    {
        bannerG�sterilecek = true;
    }
    public void BannerGizle()
    {
        bannerG�sterilecek = false;
        Advertisement.Banner.Hide();
    }
}
