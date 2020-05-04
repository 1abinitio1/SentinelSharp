namespace SentinelSharp
{
    enum SentinelPlatform { Sentinel1, Sentinel2, Sentinel3 };
    enum Sentinel1Product { SLC, GRD, OCN };
    enum SensorMode { SM, IW, EW, WV };

    /// <summary>
    /// Direction of the orbit (ascending, descending) for the oldest image data in the product (the start of the product).
    /// </summary>
    enum OrbitDirection { Ascending, Descending }; //implemented

    /// <summary>
    /// Valid polarisations for the S1 SAR instrument. Possible values are: HH, VV, HV, VH, HH HV, VV VH
    /// </summary>
    enum S1_PolarisationMode { HH, VV, HV, VH, HH_HV, VV_VH }; //implemented
    
    /// <summary>
    /// Used to perform a search based on the Sentinel1 product type
    /// </summary>
    enum Sentinel1ProductType { SLC, GRD, OCN }; //implemented

    /// <summary>
    /// Used to perform a search based on the Sentinel2 product type
    /// </summary>
    enum Sentinel2ProductType { S2MSI2A, S2MSI1C, S2MS2Ap }; //implemented

    /// <summary>
    /// Used to perform a search based on the Sentinel3 product type
    /// </summary>
    enum Sentinel3ProductType { SR_1_SRA___, SR_1_SRA_A, SR_1_SRA_BS, SR_2_LAN___, OL_1_EFR___, OL_1_ERR___, OL_2_LFR___, OL_2_LRR___, SL_1_RBT___, SL_2_LST___, SY_2_SYN___, SY_2_V10___, SY_2_VG1___, SY_2_VGP___ }; //implemented

    /// <summary>
    /// Used to perform a search based on the Sentinel5 precursor product type
    /// </summary>
    enum Sentinel5pProductType { L1B_IR_SIR, L1B_IR_UVN, L1B_RA_BD1, L1B_RA_BD2, L1B_RA_BD3, L1B_RA_BD4, L1B_RA_BD5, L1B_RA_BD6, L1B_RA_BD7, L1B_RA_BD8, L2__AER_AI, L2__AER_LH, L2__CH4, L2__CLOUD_, L2__CO____, L2__HCHO__, L2__NO2___, L2__NP_BD3, L2__NP_BD6, L2__NP_BD7, L2__O3_TCL, L2__O3____, L2__SO2___ }; //implemented

    /// <summary>
    /// Valid sensor mode for the S1 SAR instrument. Possible values are: SM, IW, EW, WV
    /// </summary>
    enum S1_SensorOperationalMode { SM, IW, EW, WV }; //implemented

    /// <summary>
    /// Search all valid swath identifiers for the Sentinel-1 SAR instrument. Look at the docs here: https://scihub.copernicus.eu/userguide/FullTextSearch for more info
    /// </summary>
    enum S1_SwathIdentifier { S1, S2, S3, S4, S5, S6, IW, IW1, IW2, IW3, EW, EW1, EW2, EW3, EW4, EW5 }; //implemented

    /// <summary>
    /// Production timeliness for each Sentinel mission. Look at the docs here: https://scihub.copernicus.eu/userguide/FullTextSearch for more info
    /// </summary>
    enum Timeliness { NRT , NRT_3h, NA, Near_Real_Time, STC, Short_Time_Critical, NTC, Fast_24h, Non_Time_Critical }; //implemented
}