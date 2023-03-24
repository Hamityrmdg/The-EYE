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

    private bool bannerGösterilecek = true;
    
    void Start()
    {
        Advertisement.Initialize(GameID, testModu);
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        BannerGoster();
    }

    
    void Update()
    {
        if (bannerGösterilecek)
        {
            if (Advertisement.IsReady(BannerPlacementID))
            {
                Advertisement.Banner.Show(BannerPlacementID);
                bannerGösterilecek=false;   
            }
        }
    }
    public void BannerGoster()
    {
        bannerGösterilecek = true;
    }
    public void BannerGizle()
    {
        bannerGösterilecek = false;
        Advertisement.Banner.Hide();
    }
}
