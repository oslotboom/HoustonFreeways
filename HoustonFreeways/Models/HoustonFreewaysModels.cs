using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using System.Xml.Linq;

namespace HoustonFreeways.Models
{

    //http://www.oscarmail.net/houstonfreeways/ebook/
    /* classes for home page */
    public class HomePage
    {
        public string PdfPath = "https://1968d90e831cd27d2017897e0c81e9a12852eb10.googledrive.com/host/0B4gwdXQk1LyieHZHSTBqd0VJSnc/pdf/"; //"http://www.oscarmail.net/houstonfreeways/ebook/"; "http://freeways.azurewebsites.net/houston-freeways-book/"
        public List<DownloadItem> Chapters { get; set; }
        public List<DownloadItem> Excerpts { get; set; }

        public HomePage()
        {
            Chapters = new List<DownloadItem>();
            Excerpts = new List<DownloadItem>();
        }

        public static HomePage BuildHomePageModel ()
        {
            HomePage homepage = new HomePage();
            homepage.Chapters.Add(new DownloadItem("", "Houston-Freeways-ebook_72ppi.pdf", "42", "Houston-Freeways-ebook_150ppi.pdf", "93", String.Empty, "Complete book", "413", String.Empty, String.Empty, false));
            homepage.Chapters.Add(new DownloadItem("preface", "front_matter_ebook_72.pdf", "0.8", "front_matter_ebook_150.pdf", "1.7", String.Empty, "Cover and Introduction", "10", String.Empty, String.Empty, false));
            homepage.Chapters.Add(new DownloadItem("1", "CH1_building_the_system_pp1-91_72.pdf", "13", "CH1_building_the_system_pp1-91_150.pdf", "16", String.Empty, "Chapter 1", "92", String.Empty, "Building the System", false));
            homepage.Chapters.Add(new DownloadItem("2","CH2_freeway_metropolis_pp92-115_72.pdf", "4", "CH2_freeway_metropolis_pp92-115_150.pdf", "9.4", String.Empty, "Chapter 2", "64", String.Empty, "Freeway Metropolis" , false));
            homepage.Chapters.Add(new DownloadItem("3","CH3_downtown_freeways_pp116-141_72.pdf", "5", "CH3_downtown_freeways_pp116-141_150.pdf", "14", String.Empty, "Chapter 3", "26", String.Empty, "Downtown Freeways", false));
            homepage.Chapters.Add(new DownloadItem("4","CH4_spokes_pp184-271_72.pdf", "19", "CH4_spokes_pp184-271_150.pdf", "50", String.Empty, "Chapter 4", "130", String.Empty, "The Spokes", false));
            homepage.Chapters.Add(new DownloadItem("5", "CH5_loops_pp272-321_72.pdf", "6.6", "CH5_loops_pp272-321_150.pdf", "18", String.Empty, "Chapter 5", "50", String.Empty, "The Loops", false));
            homepage.Chapters.Add(new DownloadItem("6", "CH6_freeway_mass_transit_pp322-339_72.pdf", "2.8", "CH6_freeway_mass_transit_pp322-339_150.pdf", "6.5", String.Empty, "Chapter 6", "18", String.Empty, "Freeway Mass Transit", false));
            homepage.Chapters.Add(new DownloadItem("7", "CH7_bridges_and_tunnels_pp340-375_72.pdf", "3.4", "CH7_bridges_and_tunnels_pp340-375_150.pdf", "9.6", String.Empty, "Chapter 7", "36", String.Empty, "Bridges and Tunnels", false));
            homepage.Chapters.Add(new DownloadItem("8", "CH8_freeway_journey_pp376-379_72.pdf", "0.3", "CH8_freeway_journey_pp376-379_150.pdf", "0.5", String.Empty, "Chapter 8", "4", String.Empty, "The Freeway Journey", false));
            homepage.Chapters.Add(new DownloadItem("notes", "Notes_ebook_pp380-404_72.pdf", "2.4", "Notes_ebook_pp380-404_150.pdf", "3.9", String.Empty, "Notes and Index", "27", String.Empty, String.Empty, false));

            homepage.Excerpts.Add(new DownloadItem("", "Gulf_Freeway_72ppi.pdf", "3.1", "Gulf_Freeway_150ppi.pdf", "8.3", String.Empty, "Gulf Freeway", "23", String.Empty, "Interstate 45 South", false));
            homepage.Excerpts.Add(new DownloadItem("", "Southwest_Freeway_72ppi.pdf", "2.5", "Southwest_Freeway_150ppi.pdf", "7.5", String.Empty, "Southwest Freeway", "18", String.Empty, "US 59 South", false));
            homepage.Excerpts.Add(new DownloadItem("", "Katy_Freeway_72ppi.pdf", "1.8", "Katy_Freeway_150ppi.pdf", "4.2", String.Empty, "Katy Freeway", "12", String.Empty, "Interstate 10 West", false));
            homepage.Excerpts.Add(new DownloadItem("", "Loop610_72ppi.pdf", "3.5", "Loop610_150ppi.pdf", "8.6", String.Empty, "The Loop", "20", String.Empty, "Interstate 610", false));
            homepage.Excerpts.Add(new DownloadItem("", "BW8_72ppi.pdf", "2.4", "BW8_150ppi.pdf", "6.8", String.Empty, "Sam Houston Tollway/Parkway", "19", String.Empty, "Beltway 8", false));
            homepage.Excerpts.Add(new DownloadItem("", "North_Freeway_72ppi.pdf", "1.5", "North_Freeway_150ppi.pdf", "3.9", String.Empty, "North Freeway", "9", String.Empty, "Interstate 45 North", false));
            homepage.Excerpts.Add(new DownloadItem("", "South_Freeway_72ppi.pdf", "1.8", "South_Freeway_150ppi.pdf", "4.2", String.Empty, "South Freeway", "10", String.Empty, "State Highway 288", false));
            homepage.Excerpts.Add(new DownloadItem("", "Eastex_Freeway_72ppi.pdf", "1.7", "Eastex_Freeway_150ppi.pdf", "4.0", String.Empty, "Eastex Freeway", "9", String.Empty, "US 59/Interstate 69 North", false));
            homepage.Excerpts.Add(new DownloadItem("", "LaPorte_Freeway_72ppi.pdf", "1.5", "LaPorte_Freeway_150ppi.pdf", "3.8", String.Empty, "LaPorte Freeway", "11", String.Empty, "State Highway 225", false));
            return homepage;
        }
    }

    public class QuickViewPage
    {
        public string Title;
        public string PdfPath;
        public string PdfSize;
        public string PdfFileSmall;
        public string PdfFileLarge;
        public string ImagePath;
        public List<QuickViewItem> Pages;

    }

    public class DownloadItem
    {
        public string ChapterNumber;
        public string IconImagePath;
        public string Title;
        public string PageCount;
        public string PdfFileSmall;
        public string PdfFileSmallSizeMB;
        public string PdfFileLarge;
        public string PdfFileLargeSizeMB;
        public string QuickViewFolder;
        public string Description;
        public bool StartOdd;//true if the first page of the chapter is an odd (right-side) page

        public DownloadItem(
            string chapterNumber,
            string pdfFileSmall,
            string pdfFileSmallSizeMB,
            string pdfFileLarge,
            string pdfFileLargeSizeMB,
            string iconImagePath,
            string title,
            string pageCount,
            string quickViewFolder,
            string description,
            bool startOdd

        )
        {
            ChapterNumber = chapterNumber;
            PdfFileSmall = pdfFileSmall;
            PdfFileSmallSizeMB = pdfFileSmallSizeMB;
            PdfFileLarge = pdfFileLarge;
            PdfFileLargeSizeMB = pdfFileLargeSizeMB;
            IconImagePath = iconImagePath;
            Title = title;
            PageCount = pageCount;
            QuickViewFolder = quickViewFolder;
            Description = description;
            StartOdd = startOdd;

        }
    }

    public class QuickViewItem
    {
        public string FilePath;
        public bool odd;
    }

    public class ChallengeItem
    {
        public string ChallengeType;
        public int Sequence;
        public int SequenceMax;
        public string Title;
        public string PhotoCredit;
        public string Hint;
        public string Answer;
        public string Map;
        public string Image;
        public string ImageHighRes;
        public string ImagePath;

        ChallengeItem(string challengeType, int sequence, int sequenceMax, string title, string photoCredit, string hint, string answer, string map, string image, string imageHighRes, string imagePath)
        {
            ChallengeType = challengeType;
            Sequence=sequence;
            SequenceMax=sequenceMax;
            Title=title;
            PhotoCredit=photoCredit;
            Hint=hint;
            Answer=answer;
            Map=map;
            Image=image;
            ImageHighRes=imageHighRes;
            ImagePath = imagePath;
        }


        public static ChallengeItem GetChallenge(string type, int challengeIndex, int sequence, int sequenceMax, string pageTitle)
        {
            string[, ,] challengeArray = (type == "aerial" ? IntializeAerialChallengeArray() : IntializeHistoricalChallengeArray());

            return new ChallengeItem(
                type,
                sequence,
                sequenceMax,
                pageTitle,
                challengeArray[challengeIndex, sequence, 2],
                challengeArray[challengeIndex, sequence, 3],
                challengeArray[challengeIndex, sequence, 4],
                challengeArray[challengeIndex, sequence, 5],
                challengeArray[challengeIndex, sequence, 0],
                challengeArray[challengeIndex, sequence, 1],
                "/images/Desktop/Challenge/" + type + "/"
                );
        }

        private static string[, ,] IntializeAerialChallengeArray()
        {
            string[, ,] challengeArray = new string[3, 15, 6];
            challengeArray[0, 0, 0] = "A01_8_45_john_24A_ice_gem2_ADJ_800.jpg";
            challengeArray[0, 0, 1] = "";
            challengeArray[0, 0, 2] = "Erik Slotboom";
            challengeArray[0, 0, 3] = "Completed in 1997";
            challengeArray[0, 0, 4] = "Interchange at Beltway 8 and the Gulf Freeway [IH 45]";
            challengeArray[0, 0, 5] = "A01_map.jpg";
            challengeArray[0, 1, 0] = "A02_59n_at_610_2A_ice_gem2 _ADJ_800.jpg";
            challengeArray[0, 1, 1] = "";
            challengeArray[0, 1, 2] = "Erik Slotboom";
            challengeArray[0, 1, 3] = "Loop intersection";
            challengeArray[0, 1, 4] = "Interchange at the Eastex Freeway [US 59] and the North Loop.";
            challengeArray[0, 1, 5] = "A02_map.jpg";
            challengeArray[0, 2, 0] = "A03_10-8_stack_looking_SW_along_i10_2A_800.jpg";
            challengeArray[0, 2, 1] = "";
            challengeArray[0, 2, 2] = "Erik Slotboom";
            challengeArray[0, 2, 3] = "The interchange will come down starting around 2005.";
            challengeArray[0, 2, 4] = "This view looks west-southwest at the interchange at the Katy Freeway [IH 10] and Beltway 8. As part of the Katy Freeway expansion, the interchange will be removed and reconstructed.";
            challengeArray[0, 2, 5] = "A03_map.jpg";
            challengeArray[0, 3, 0] = "A04_10w_at_houston_street_ice_gem2_800.jpg";
            challengeArray[0, 3, 1] = "";
            challengeArray[0, 3, 2] = "Erik Slotboom";
            challengeArray[0, 3, 3] = "On the approach to downtown.";
            challengeArray[0, 3, 4] = "This view shows the Katy Freeway [IH-10] near Houston Street where the elevated structure for high occupancy vehicles begins.";
            challengeArray[0, 3, 5] = "A04_map.jpg";
            challengeArray[0, 4, 0] = "A05_225_20A_ADJ_800.jpg";
            challengeArray[0, 4, 1] = "A05_225_20A_ADJ_2500.jpg";
            challengeArray[0, 4, 2] = "Erik Slotboom";
            challengeArray[0, 4, 3] = "The freeway comes to a grinding halt just ahead.";
            challengeArray[0, 4, 4] = "This view looks west along the La Porte Freeway [SH 225] at the interchange with Loop 610. The inner loop section of the La Porte Freeway was cancelled, and the freeway abruptly ends just inside the loop.";
            challengeArray[0, 4, 5] = "A05_map.jpg";
            challengeArray[0, 5, 0] = "A06_249_21A_looking_NW_ADJ_ADJ_800.jpg";
            challengeArray[0, 5, 1] = "A06_249_21A_looking_NW_ADJ_ADJ_2500.jpg";
            challengeArray[0, 5, 2] = "Erik Slotboom";
            challengeArray[0, 5, 3] = "Freeway built for a computer company.";
            challengeArray[0, 5, 4] = "This shows the Tomball Parkway [SH 249] just south of FM 1960. The freeway was built in response to the explosive growth in the region which was fueled by Compaq Computer. Hewlett Packard bought out Compaq in 2002.";
            challengeArray[0, 5, 5] = "A06_map.jpg";
            challengeArray[0, 6, 0] = "A07_290_bw8_4A_ADJ_800.jpg";
            challengeArray[0, 6, 1] = "";
            challengeArray[0, 6, 2] = "Erik Slotboom";
            challengeArray[0, 6, 3] = "Jersey Village is nearby.";
            challengeArray[0, 6, 4] = "This view shows the interchange at Beltway 8 and the Northwest Freeway [US 290].";
            challengeArray[0, 6, 5] = "A07_map.jpg";
            challengeArray[0, 7, 0] = "A08_45s_calhoun_26A_800.jpg";
            challengeArray[0, 7, 1] = "";
            challengeArray[0, 7, 2] = "Erik Slotboom";
            challengeArray[0, 7, 3] = "University of Houston nearby.";
            challengeArray[0, 7, 4] = "This view looks northbound along the Gulf Freeway [IH 45] on its approach to downtown.";
            challengeArray[0, 7, 5] = "A08_map.jpg";
            challengeArray[0, 8, 0] = "A09_59_288_A_ADJ_CROP_800.jpg";
            challengeArray[0, 8, 1] = "A09_59_288_A_ADJ_CROP_2500.jpg";
            challengeArray[0, 8, 2] = "Erik Slotboom";
            challengeArray[0, 8, 3] = "Downtown mega-merge zone.";
            challengeArray[0, 8, 4] = "Looking south along the multiplex of US 59 and SH 288 on the south side of downtown.";
            challengeArray[0, 8, 5] = "A09_map.jpg";
            challengeArray[0, 9, 0] = "A10_59s_newcastle_14a_ice_gem2_ADJ_800.jpg";
            challengeArray[0, 9, 1] = "A10_59s_newcastle_14a_ice_gem2_ADJ_2500.jpg";
            challengeArray[0, 9, 2] = "Erik Slotboom";
            challengeArray[0, 9, 3] = "Houston's busiest freeway inside the loop.";
            challengeArray[0, 9, 4] = "This view looks along the Southwest Freeway at Newcastle, just inside the loop.";
            challengeArray[0, 9, 5] = "A10_map.jpg";
            challengeArray[0, 10, 0] = "A11_westpark_looking_west_at_bw8_CROP_800.jpg";
            challengeArray[0, 10, 1] = "A11_westpark_looking_west_at_bw8_CROP_2500.jpg";
            challengeArray[0, 10, 2] = "Erik Slotboom";
            challengeArray[0, 10, 3] = "A lot has changed since this photo was taken in May 2002.";
            challengeArray[0, 10, 4] = "This view looks west along the Westpark Tollway corridor at the Beltway 8 interchange.";
            challengeArray[0, 10, 5] = "A11_map.jpg";
            challengeArray[0, 11, 0] = "A12_59n_tidwell_hov_22a_LIGHTENED_ADJ_800.jpg";
            challengeArray[0, 11, 1] = "A12_59n_tidwell_hov_22a_LIGHTENED_ADJ_3000.jpg";
            challengeArray[0, 11, 2] = "Erik Slotboom";
            challengeArray[0, 11, 3] = "Airport-bound motorists see this.";
            challengeArray[0, 11, 4] = "Looking north along the Eastex Freeway [US 59] with the connection ramp to the Tidwell Park and Ride.";
            challengeArray[0, 11, 5] = "A12_map.jpg";
            challengeArray[0, 12, 0] = "A13_59s_greenway_plaza_16A_ice_gem2_ADJ_800.jpg";
            challengeArray[0, 12, 1] = "";
            challengeArray[0, 12, 2] = "Erik Slotboom";
            challengeArray[0, 12, 3] = "A neighborhood was cleared to make way for the real estate development.";
            challengeArray[0, 12, 4] = "This view looks outbound along the Southwest Freeway [US 59] with the Greenway Plaza office development on the right.";
            challengeArray[0, 12, 5] = "A13_map.jpg";
            challengeArray[0, 13, 0] = "A14_59_downtown_john_12ACROP_ADJ_800.jpg";
            challengeArray[0, 13, 1] = "";
            challengeArray[0, 13, 2] = "Erik Slotboom";
            challengeArray[0, 13, 3] = "Convention Center nearby.";
            challengeArray[0, 13, 4] = "This view looks south along US 59 downtown, with the interchange with IH 45 just ahead.";
            challengeArray[0, 13, 5] = "A14_map.jpg";
            challengeArray[0, 14, 0] = "A15_59_downtown_A_800.jpg";
            challengeArray[0, 14, 1] = "";
            challengeArray[0, 14, 2] = "Erik Slotboom";
            challengeArray[0, 14, 3] = "Construction is nearing completion in late 2003.";
            challengeArray[0, 14, 4] = "This shows the construction of US 59 on the northeast side of downtown.";
            challengeArray[0, 14, 5] = "A15_map.jpg";
            challengeArray[1, 0, 0] = "B01_290_at_bw8_23A_ice_gem2_ADJ_800.jpg";
            challengeArray[1, 0, 1] = "";
            challengeArray[1, 0, 2] = "Erik Slotboom";
            challengeArray[1, 0, 3] = "After the Katy Freeway, this freeway is next in line for a major expansion.";
            challengeArray[1, 0, 4] = "This view looks east along the Northwest Freeway [US 290] at the Beltway 8 interchange.";
            challengeArray[1, 0, 5] = "B01_map.jpg";
            challengeArray[1, 1, 0] = "B02_10w_Shepherd_9A_ice_gem2_800.jpg";
            challengeArray[1, 1, 1] = "";
            challengeArray[1, 1, 2] = "Erik Slotboom";
            challengeArray[1, 1, 3] = "This freeway has had some water problems.";
            challengeArray[1, 1, 4] = "This looks east along the Katy Freeway [IH 10] near Shepherd. This section of freeway flooded during Tropical Storm Allison in June 2001 and provided the dramatic photos of the 18-wheeler carcasses floating in the water.";
            challengeArray[1, 1, 5] = "B02_map.jpg";
            challengeArray[1, 2, 0] = "B03_8e_ship_channel_bridge_angel_35A_ice_gem2_ADJ_800.jpg";
            challengeArray[1, 2, 1] = "B03_8e_ship_channel_bridge_angel_35A_ice_gem2_ADJ_2812.jpg";
            challengeArray[1, 2, 2] = "Erik Slotboom";
            challengeArray[1, 2, 3] = "Pay up if you cross this bridge.";
            challengeArray[1, 2, 4] = "This is the Beltway 8/Sam Houston Tollway Ship Channel Bridge looking northeast.";
            challengeArray[1, 2, 5] = "B03_map.jpg";
            challengeArray[1, 3, 0] = "B04_610_traffic_18A_ADJ_800.jpg";
            challengeArray[1, 3, 1] = "B04_610_traffic_18A_ADJ_2000.jpg";
            challengeArray[1, 3, 2] = "Erik Slotboom";
            challengeArray[1, 3, 3] = "The Galleria is nearby.";
            challengeArray[1, 3, 4] = "The view looks north along the West Loop at Memorial Park.";
            challengeArray[1, 3, 5] = "B04_map.jpg";
            challengeArray[1, 4, 0] = "B05_59_10_construction_ice_gem4_800.jpg";
            challengeArray[1, 4, 1] = "";
            challengeArray[1, 4, 2] = "Erik Slotboom";
            challengeArray[1, 4, 3] = "A baseball stadium is nearby.";
            challengeArray[1, 4, 4] = "This is the new downtown distribution system for US 59 north on the northeast side of downtown.";
            challengeArray[1, 4, 5] = "B05_map.jpg";
            challengeArray[1, 5, 0] = "B06_59_weslayen_35A_ice_gem3_ADJ_800.jpg";
            challengeArray[1, 5, 1] = "";
            challengeArray[1, 5, 2] = "Erik Slotboom";
            challengeArray[1, 5, 3] = "The land on the left of the freeway was once a neighborhood.";
            challengeArray[1, 5, 4] = "This is the Southwest Freeway [US 59] at Weslayan with Greenway Plaza on the left side of the freeway.";
            challengeArray[1, 5, 5] = "B06_map.jpg";
            challengeArray[1, 6, 0] = "B07_45s_dual_T_15A_CROP_ADJ_800.jpg";
            challengeArray[1, 6, 1] = "";
            challengeArray[1, 6, 2] = "Erik Slotboom";
            challengeArray[1, 6, 3] = "Hobby Airport is nearby.";
            challengeArray[1, 6, 4] = "This is the dual T-ramp on the Gulf Freeway near Edgebrook.";
            challengeArray[1, 6, 5] = "B07_map.jpg";
            challengeArray[1, 7, 0] = "B08_249_11A_800.jpg";
            challengeArray[1, 7, 1] = "";
            challengeArray[1, 7, 2] = "Erik Slotboom";
            challengeArray[1, 7, 3] = "Willowbrook Mall is nearby.";
            challengeArray[1, 7, 4] = "This view looks south along the Tomball Parkway, SH 249.";
            challengeArray[1, 7, 5] = "B08_map.jpg";
            challengeArray[1, 8, 0] = "B09_225_34A_ice_gem2_800.jpg";
            challengeArray[1, 8, 1] = "B09_225_34A_ice_gem2_2500.jpg";
            challengeArray[1, 8, 2] = "Erik Slotboom";
            challengeArray[1, 8, 3] = "The city is named after an [often hunted] animal.";
            challengeArray[1, 8, 4] = "This is the La Porte Freeway [SH 225] in Deer Park with the Shell petrochemical plant in the background.";
            challengeArray[1, 8, 5] = "B09_map.jpg";
            challengeArray[1, 9, 0] = "B10_610_bridge_1A_ice_gem2_800.jpg";
            challengeArray[1, 9, 1] = "";
            challengeArray[1, 9, 2] = "Erik Slotboom";
            challengeArray[1, 9, 3] = "Houston's first high-level bridge, opened in 1973.";
            challengeArray[1, 9, 4] = "The Loop 610 ship channel crossing.";
            challengeArray[1, 9, 5] = "B10_map.jpg";
            challengeArray[1, 10, 0] = "B11_290_hov_pretzel_11A_ice_gem3_800.jpg";
            challengeArray[1, 10, 1] = "";
            challengeArray[1, 10, 2] = "Erik Slotboom";
            challengeArray[1, 10, 3] = "At a corner of the Loop.";
            challengeArray[1, 10, 4] = "This is the HOV struture at the interchange of Loop 610 and the Northwest Freeway [US 290]";
            challengeArray[1, 10, 5] = "B11_map.jpg";
            challengeArray[1, 11, 0] = "B12_red_bluff_25A_ADJ_800.jpg";
            challengeArray[1, 11, 1] = "";
            challengeArray[1, 11, 2] = "Erik Slotboom";
            challengeArray[1, 11, 3] = "This was a planned freeway that was not built.";
            challengeArray[1, 11, 4] = "This view looks southeast along Red Bluff Road. Red Bluff Road was constructed with frontage roads for a planned future freeway, but as of 2003 there are no plans to build the main lanes as a freeway or tollway.";
            challengeArray[1, 11, 5] = "B12_map.jpg";
            challengeArray[1, 12, 0] = "B13_jfk_at_bw8_ice_gem3_800.jpg";
            challengeArray[1, 12, 1] = "";
            challengeArray[1, 12, 2] = "Erik Slotboom";
            challengeArray[1, 12, 3] = "Your bags are probably packed when you drive here.";
            challengeArray[1, 12, 4] = "This view looks north at the interchange of Beltway 8 North and J.F. Kennedy Blvd.";
            challengeArray[1, 12, 5] = "B13_map.jpg";
            challengeArray[1, 13, 0] = "B14_59n_hov_at_tidwell_23a_800.jpg";
            challengeArray[1, 13, 1] = "";
            challengeArray[1, 13, 2] = "Erik Slotboom";
            challengeArray[1, 13, 3] = "Motorists driving here may be Kingwood-bound.";
            challengeArray[1, 13, 4] = "This is the Eastex Freeway [US 59 north] at the Tidwell transit center.";
            challengeArray[1, 13, 5] = "B14_map.jpg";
            challengeArray[1, 14, 0] = "B15_8s_20A_ADJ_800.jpg";
            challengeArray[1, 14, 1] = "";
            challengeArray[1, 14, 2] = "Erik Slotboom";
            challengeArray[1, 14, 3] = "It's a tollway.";
            challengeArray[1, 14, 4] = "This is the Southeast section of Beltway 8/Sam Houston Tollway.";
            challengeArray[1, 14, 5] = "B15_map.jpg";
            challengeArray[2, 0, 0] = "C01_59_at_bw8_17_2003-05-28_ice_gem2_ADJ_800.jpg";
            challengeArray[2, 0, 1] = "";
            challengeArray[2, 0, 2] = "Erik Slotboom";
            challengeArray[2, 0, 3] = "A beltway crossing";
            challengeArray[2, 0, 4] = "This view looks southwest along the Southwest Freeway [US 59]. The interchange was completed in 1997. Photo taken May 2003.";
            challengeArray[2, 0, 5] = "C01_map.jpg";
            challengeArray[2, 1, 0] = "C02_45n_wishbone_7A_ice_gem2_ADJ_800.jpg";
            challengeArray[2, 1, 1] = "";
            challengeArray[2, 1, 2] = "Erik Slotboom";
            challengeArray[2, 1, 3] = "Airport is nearby";
            challengeArray[2, 1, 4] = "This view looks north along the North Freeway [IH 45] just south of FM 1960. The expansion to the present-day configuration was completed in 1998.";
            challengeArray[2, 1, 5] = "C02_map.jpg";
            challengeArray[2, 2, 0] = "C03_45_downtown_11_2003-05-28_ice_gem2_ADJ copy.jpg";
            challengeArray[2, 2, 1] = "";
            challengeArray[2, 2, 2] = "Erik Slotboom";
            challengeArray[2, 2, 3] = "On the northwest side of downtown.";
            challengeArray[2, 2, 4] = "This view looks south along IH 45. Photo taken May 2003.";
            challengeArray[2, 2, 5] = "C03_map.jpg";
            challengeArray[2, 3, 0] = "C04_8n_at_hardy_21A_ice_gem2_ADJ_800.jpg";
            challengeArray[2, 3, 1] = "";
            challengeArray[2, 3, 2] = "Erik Slotboom";
            challengeArray[2, 3, 3] = "Some motorists in this photo are paying a toll.";
            challengeArray[2, 3, 4] = "This view looks west along the North Beltway 8 with the Hardy Toll Road crossing in the foreground. The new connector ramp to the Hardy Toll Road is under construction in this November 2002 photo.";
            challengeArray[2, 3, 5] = "C04_map.jpg";
            challengeArray[2, 4, 0] = "C05_59_arches_19_2003-05-29_ice_gem2_ADJ_800.jpg";
            challengeArray[2, 4, 1] = "";
            challengeArray[2, 4, 2] = "Erik Slotboom";
            challengeArray[2, 4, 3] = "This was Houston's first major freeway trench when it first opened in 1961.";
            challengeArray[2, 4, 4] = "This view looks west along the Southwest Freeway [US 59] with the Mandell crossing in the foreground. The trench expansion and addition of arched bridges was completed in late 2002.";
            challengeArray[2, 4, 5] = "C05_map.jpg";
            challengeArray[2, 5, 0] = "C06_288_59_downtown_22A_ice_gem2_ADJ_ADJ_800.jpg";
            challengeArray[2, 5, 1] = "";
            challengeArray[2, 5, 2] = "Erik Slotboom";
            challengeArray[2, 5, 3] = "Just south of downtown.";
            challengeArray[2, 5, 4] = "This view looks north along the US 58/SH 288 intersection.";
            challengeArray[2, 5, 5] = "C06_map.jpg";
            challengeArray[2, 6, 0] = "C07_249_compaq_11A_ice_gem2_ADJ_ADJ_800.jpg";
            challengeArray[2, 6, 1] = "";
            challengeArray[2, 6, 2] = "Erik Slotboom";
            challengeArray[2, 6, 3] = "Lots of computery stuff going on here.";
            challengeArray[2, 6, 4] = "This is SH 249 at the Hewlett Packard [formerly Compaq] campus.";
            challengeArray[2, 6, 5] = "C07_map.jpg";
            challengeArray[2, 7, 0] = "C08_10w_at_bw8_16A_COLOR_DAMAGE_adj_ADJ_800.jpg";
            challengeArray[2, 7, 1] = "";
            challengeArray[2, 7, 2] = "Erik Slotboom";
            challengeArray[2, 7, 3] = "Reconstruction to begin soon.";
            challengeArray[2, 7, 4] = "This is the interchange at the Katy Freeway [IH 10] and Beltway 8. The contract to rebuild this interchange is scheduled to be awarded in 2004.";
            challengeArray[2, 7, 5] = "C08_map.jpg";
            challengeArray[2, 8, 0] = "C09_8_memorial_bend_13A_ice_gem2_ADJ_ADJ_800.jpg";
            challengeArray[2, 8, 1] = "";
            challengeArray[2, 8, 2] = "Erik Slotboom";
            challengeArray[2, 8, 3] = "The neighborhood has the word Bend in it";
            challengeArray[2, 8, 4] = "This is Beltway 8 passing through the Memorial Bend area in west Houston. This was one of the more controversial sections of the Beltway. It opened in 1988.";
            challengeArray[2, 8, 5] = "C09_map.jpg";
            challengeArray[2, 9, 0] = "C10_downtown_ramps_6_2003-05-29_ice_gem2_800.jpg";
            challengeArray[2, 9, 1] = "";
            challengeArray[2, 9, 2] = "Erik Slotboom";
            challengeArray[2, 9, 3] = "Traffic is nearly always backed up here.";
            challengeArray[2, 9, 4] = "These are the connections from US 59 to the Pierce Elevated [IH 45].";
            challengeArray[2, 9, 5] = "C10_map.jpg";
            challengeArray[2, 10, 0] = "C11_hardy_airport_connector_17A_ice_gem3_CROP_ADJ_800.jpg";
            challengeArray[2, 10, 1] = "";
            challengeArray[2, 10, 2] = "Erik Slotboom";
            challengeArray[2, 10, 3] = "One tollway connecting to another";
            challengeArray[2, 10, 4] = "This view looks west along the Hardy Toll Road Airport connector with the Hardy Toll Road interchange at the top.";
            challengeArray[2, 10, 5] = "C11_map.jpg";
            challengeArray[2, 11, 0] = "C12_8_westpark_14A_ice_gem2_ADJ_800.jpg";
            challengeArray[2, 11, 1] = "C12_8_westpark_14A_ice_gem2_ADJ_2500.jpg";
            challengeArray[2, 11, 2] = "Erik Slotboom";
            challengeArray[2, 11, 3] = "Where the tollways cross";
            challengeArray[2, 11, 4] = "This looks north along the Sam Houston Tollway [Beltway 8] at the Westpark Tollway contruction zone in May 2003. Notice something very unfortunate being built in this photo: a cloverleaf connection!";
            challengeArray[2, 11, 5] = "C12_map.jpg";
            challengeArray[2, 12, 0] = "C13_59_downtown_15A_ice_gem2_ADJ_CROP_800.jpg";
            challengeArray[2, 12, 1] = "";
            challengeArray[2, 12, 2] = "Erik Slotboom";
            challengeArray[2, 12, 3] = "Downtown area interchange";
            challengeArray[2, 12, 4] = "This view looks northeast at the US 59 interchange complex construction nearing completion in May 2003.";
            challengeArray[2, 12, 5] = "C13_map.jpg";
            challengeArray[2, 13, 0] = "C14_hardy_22A_nov_2002_ice_gem2_ADJ_800.jpg";
            challengeArray[2, 13, 1] = "";
            challengeArray[2, 13, 2] = "Erik Slotboom";
            challengeArray[2, 13, 3] = "Only one Houston highway has a railroad down its middle.";
            challengeArray[2, 13, 4] = "Looking north along the Hardy Toll Road in November 2002.";
            challengeArray[2, 13, 5] = "C14_map.jpg";
            challengeArray[2, 14, 0] = "C15_59_rice_10_ice_gem2_800.jpg";
            challengeArray[2, 14, 1] = "";
            challengeArray[2, 14, 2] = "Erik Slotboom";
            challengeArray[2, 14, 3] = "Houston's busiest freeway";
            challengeArray[2, 14, 4] = "Looking west along the Southwest Freeway [US 59] just west of Loop 610. On the left is the nearly complete Westpark Tollway.";
            challengeArray[2, 14, 5] = "C15_map.jpg";

            return challengeArray;
        }

        private static string[, ,] IntializeHistoricalChallengeArray()
        {
            string[, ,] challengeArray = new string[3, 15, 6];

            challengeArray[0, 0, 0] = "B01_59s_at_weslayan_GEM3_ADJ_800.jpg";
            challengeArray[0, 0, 1] = "";
            challengeArray[0, 0, 2] = "Chuck Fuhs";
            challengeArray[0, 0, 3] = "Going to the Summit";
            challengeArray[0, 0, 4] = "Inbound on the original Southwest Freeway, sometime in the 1970s. Expansion of this section of freeway was completed in 1992.";
            challengeArray[0, 0, 5] = "B01_challenge_59s_welayan.jpg";
            challengeArray[0, 1, 0] = "B02_146_bridge_tower_const_may_1990_grB_SLOT_14_800.jpg";
            challengeArray[0, 1, 1] = "";
            challengeArray[0, 1, 2] = "TxDOT";
            challengeArray[0, 1, 3] = "Connecting to Baytown";
            challengeArray[0, 1, 4] = "Construction of the double-diamond tower for the SH 146 Fred Hartman Bridge in 1990.";
            challengeArray[0, 1, 5] = "B02_challenge_146_bridge.jpg";
            challengeArray[0, 2, 0] = "B03_59s_at_hazard_1974_800.jpg";
            challengeArray[0, 2, 1] = "";
            challengeArray[0, 2, 2] = "Chuck Fuhs";
            challengeArray[0, 2, 3] = "Driving this freeway is now an overarching experience.";
            challengeArray[0, 2, 4] = "The original Southwest Freeway looking east from Hazard Street in 1974. Expansion of this section of freeway with addition of the arched spans was completed in late 2001. The bridge just ahead, as well as the Hazard Street and two others, was demolished in 2000.";
            challengeArray[0, 2, 5] = "B03_challenge_59s_hazard.jpg";
            challengeArray[0, 3, 0] = "B04_45d_at_59_11-apr-1972_brB_SLOT_15_800.jpg";
            challengeArray[0, 3, 1] = "B04_45d_at_59_11-apr-1972_brB_SLOT_15_2212.jpg";
            challengeArray[0, 3, 2] = "TxDOT";
            challengeArray[0, 3, 3] = "This was the last major project of the first wave of downtown freeway construction.";
            challengeArray[0, 3, 4] = "This view shows the US 59-IH 45 interchange on the south side of downtown under construction in 1972. The interchange and US 59 Freeway were opened in September 1974.";
            challengeArray[0, 3, 5] = "B04_challenge_45s_59_aerial.jpg";
            challengeArray[0, 4, 0] = "B05_8e_1981-02-00_bridge_construction_tti_ROTATE_CROP_800.jpg";
            challengeArray[0, 4, 1] = "";
            challengeArray[0, 4, 2] = "Chuck Fuhs";
            challengeArray[0, 4, 3] = "Houston's first toll facility.";
            challengeArray[0, 4, 4] = "This shows the Beltway 8 Ship channel Bridge under construction in February 1981. The bridge opened in May 1982.";
            challengeArray[0, 4, 5] = "B05_challenge_8_bridge.jpg";
            challengeArray[0, 5, 0] = "B06_45s_scott_feb-84_th619.14_HP_800.jpg";
            challengeArray[0, 5, 1] = "B06_45s_scott_feb-84_th619.14_HP_2800.jpg";
            challengeArray[0, 5, 2] = "Chuck Fuhs";
            challengeArray[0, 5, 3] = "Houston's first freeway.";
            challengeArray[0, 5, 4] = "This shows the original Gulf Freeway [IH-45] in February 1984, just prior to the reconstruction that added the elevated structures on both sides of the freeway.";
            challengeArray[0, 5, 5] = "B06_challenge_45s_scott.jpg";
            challengeArray[0, 6, 0] = "B07_10w_at_bw8_stack_const_oct-87_HD151-07_CROP_ADJ_800.jpg";
            challengeArray[0, 6, 1] = "";
            challengeArray[0, 6, 2] = "Chuck Fuhs";
            challengeArray[0, 6, 3] = "This structure will be demolished around 2005 or 2006.";
            challengeArray[0, 6, 4] = "This view looks west along the Katy Freeway [IH-10] showing the structures for the interchange ramps at Beltway 8/Sam Houston Tollway in October 1987.";
            challengeArray[0, 6, 5] = "B07_challenge_10w_at_8_fuhs.jpg";
            challengeArray[0, 7, 0] = "B08_59s_1980-02-00_looking_n_at_hillcroft_800.jpg";
            challengeArray[0, 7, 1] = "B08_59s_1980-02-00_looking_n_at_hillcroft_2700.jpg";
            challengeArray[0, 7, 2] = "Texas Transportation Institute";
            challengeArray[0, 7, 3] = "The curve in the freeway just ahead was notorious for its traffic slowdowns.";
            challengeArray[0, 7, 4] = "This view looks northbound along the original Southwest Freeway at Hillcroft in 1980. The freeway widening was completed in 1992. Notice Richardson Chevrolet on the left side of the photo. I still remember the Richardson Chevrolet theme song used in its advertisements: Richardson [horn music] Chevrolet, largest dealer in the great southwest [horns] ... . The location later became another Chevrolet dealer and was later demolished.";
            challengeArray[0, 7, 5] = "B08_challenge_59s_hillcroft.jpg";
            challengeArray[0, 8, 0] = "B09_59n_610_C_ADJUSTED_ADJ_800.jpg";
            challengeArray[0, 8, 1] = "";
            challengeArray[0, 8, 2] = "TxDOT";
            challengeArray[0, 8, 3] = "Kelly Road";
            challengeArray[0, 8, 4] = "This is the connection to the original north loop [Loop 137] from the Eastex Freeway in 1973. There was an accident-prone traffic circle at this intersection. The former north Loop is now called Kelley Road.";
            challengeArray[0, 8, 5] = "B09_challenge_59n_kelley.jpg";
            challengeArray[0, 9, 0] = "B10_gulf_freeway_median_ADJ_800.jpg";
            challengeArray[0, 9, 1] = "B10_gulf_freeway_median_3700.jpg";
            challengeArray[0, 9, 2] = "TxDOT";
            challengeArray[0, 9, 3] = "Houston's only freeway in the 1940s.";
            challengeArray[0, 9, 4] = "This view looks inbound along the original Gulf Freeway just south of the downtown terminus. Notice that the original freeway did not have a center guard rail.";
            challengeArray[0, 9, 5] = "B10_challenge_45s_gulf_no_median.jpg";
            challengeArray[0, 10, 0] = "B11_tti_sw_fwy_westpark_curve_pre_89_800.jpg";
            challengeArray[0, 10, 1] = "B11_tti_sw_fwy_westpark_curve_pre_89_1583.jpg";
            challengeArray[0, 10, 2] = "Texas Transportation Institute";
            challengeArray[0, 10, 3] = "This was a serious traffic choke point.";
            challengeArray[0, 10, 4] = "This is the original Southwest Freeway at the Westpark curve, sometime in the 1970s. Due to the curve and sharp grades on the overpass, traffic always seemed to be slow. Notice the large billboard right next to the freeway. The freeway was expanded in 1992, and in 2003 the Westpark Tollway is under construction. As I kid I went to go-cart track in the upper part of the photo.";
            challengeArray[0, 10, 5] = "B11_challenge_59s_westpark_curve.jpg";
            challengeArray[0, 11, 0] = "B12_45s_1981-06-00_orig_freeway_tti_ADJ_800.jpg";
            challengeArray[0, 11, 1] = "B12_45s_1981-06-00_orig_freeway_tti_ADJ_3000.jpg";
            challengeArray[0, 11, 2] = "Texas Transportation Institute";
            challengeArray[0, 11, 3] = "Approaching downtown on an antiquated freeway.";
            challengeArray[0, 11, 4] = "This is the original Gulf Freeway in 1981, just before expansion began.";
            challengeArray[0, 11, 5] = "B12_challenge_45s_traffic.jpg";
            challengeArray[0, 12, 0] = "B13_59s_spur_527_looking_s_may-61_grC_SLOT_021_800.jpg";
            challengeArray[0, 12, 1] = "";
            challengeArray[0, 12, 2] = "TxDOT";
            challengeArray[0, 12, 3] = "It's a spur kind of thing.";
            challengeArray[0, 12, 4] = "This view looks south-southwest along Spur 527 in May 1961 just before its opening in July 1961.";
            challengeArray[0, 12, 5] = "B13_challenge_spur_527.jpg";
            challengeArray[0, 13, 0] = "B14_59s_traffic_10-1974_5-15pm_800.jpg";
            challengeArray[0, 13, 1] = "";
            challengeArray[0, 13, 2] = "Chuck Fuhs";
            challengeArray[0, 13, 3] = "The photographer was at the Summit.";
            challengeArray[0, 13, 4] = "This view looks outbound along the original Southwest Freeway in 1974. The Summit sports arena [now Compaq center] opened in 1975 right behind the point of this photo.";
            challengeArray[0, 13, 5] = "B14_challenge_59s_traffic.jpg";
            challengeArray[0, 14, 0] = "B15_8_at_59_ramp_construction_33A_ice_gem2_800.jpg";
            challengeArray[0, 14, 1] = "B15_8_at_59_ramp_construction_33A_ice_gem2_2500.jpg";
            challengeArray[0, 14, 2] = "Erik Slotboom";
            challengeArray[0, 14, 3] = "An airport is nearby.";
            challengeArray[0, 14, 4] = "This shows the construction of the Beltway 8 main lanes and a connector ramp in May 2002 at the intersection of Beltway 8 and the Eastex Freeway [US 59].";
            challengeArray[0, 14, 5] = "B15_challenge_59n_bw8_ramp.jpg";
            challengeArray[1, 0, 0] = "I01_interchange_2_HiRes_ice_gem4_ADJ_800.jpg";
            challengeArray[1, 0, 1] = "I01_interchange_2_HiRes_ice_gem4_ADJ_2500.jpg";
            challengeArray[1, 0, 2] = "Allen Moradi";
            challengeArray[1, 0, 3] = "Houston's largest freeway construction project for the 2003-2008 period.";
            challengeArray[1, 0, 4] = "This is a view of the construction zone for the interchange at the Katy Freeway [IH-10] and Beltway 8 in 1988. The interchange was the first five-level structure in Houston and was completed in 1989. The Katy Freeway reconstruction project began in 2003, and the contract for rebuilding this interchange is scheduled for award in 2004.";
            challengeArray[1, 0, 5] = "I01_challenge_10w_at_8.jpg";
            challengeArray[1, 1, 0] = "I02_59_at_45_aug-1972_HD106-10_800.jpg";
            challengeArray[1, 1, 1] = "";
            challengeArray[1, 1, 2] = "Chuck Fuhs";
            challengeArray[1, 1, 3] = "Downtown non-interstate.";
            challengeArray[1, 1, 4] = "This view looks along US 59 at the interchange with IH 45 in August 1972. The freeway was opened in September 1974.";
            challengeArray[1, 1, 5] = "I02_challenge_59_downtown.jpg";
            challengeArray[1, 2, 0] = "I03_59s_1978-07-00_at_chimney_rock_ADJ_ADJ_800.jpg";
            challengeArray[1, 2, 1] = "I03_59s_1978-07-00_at_chimney_rock_ADJ_ADJ_2770.jpg";
            challengeArray[1, 2, 2] = "Texas Transportation Institute";
            challengeArray[1, 2, 3] = "Rock around the clock.";
            challengeArray[1, 2, 4] = "This view looks west along the Southwest Freeway at Chimney Rock in 1978. It is hard to believe that the freeway had only 3 inbound lanes at Chimney Rock. As Houston Freeways points out, inadequate capacity just outside Loop 610 on the radial freeways was one of the worst elements of Houston's freeway implementation.";
            challengeArray[1, 2, 5] = "I03_challenge_59s_chimney_rock.jpg";
            challengeArray[1, 3, 0] = "I04_8_45_construction_A_REPARIED_CROPPED_800.jpg";
            challengeArray[1, 3, 1] = "I04_8_45_construction_A_REPARIED_CROPPED_2000.jpg";
            challengeArray[1, 3, 2] = "Williams Brothers Construction";
            challengeArray[1, 3, 3] = "Beach-bound motorists saw this.";
            challengeArray[1, 3, 4] = "This view shows beam placement for the interchange at the Gulf Freeway [IH 45] and the South Beltway 8 in late 1996 or early 1997. The interchange was completed in 1997.";
            challengeArray[1, 3, 5] = "I04_challenge_45s_at_BW8.jpg";
            challengeArray[1, 4, 0] = "I05_gulf_freeway_aerial_at_calhoun_B_const_ADJUSTED_ADJ_800.jpg";
            challengeArray[1, 4, 1] = "I05_gulf_freeway_aerial_at_calhoun_B_const_ADJUSTED_ADJ_3077.jpg";
            challengeArray[1, 4, 2] = "TxDOT";
            challengeArray[1, 4, 3] = "First of its kind in Houston.";
            challengeArray[1, 4, 4] = "This view shows the construction of the Gulf Freeway in 1948. The freeway was officially opened on September 30, 1948.";
            challengeArray[1, 4, 5] = "I05_challenge_45s_aerial_1948.jpg";
            challengeArray[1, 5, 0] = "I06_59_at_610_construction_BW_ADJUSTED_300dpi_550.jpg";
            challengeArray[1, 5, 1] = "";
            challengeArray[1, 5, 2] = "TxDOT";
            challengeArray[1, 5, 3] = "Houston's busiest interchange";
            challengeArray[1, 5, 4] = "This is the structure for the West Loop main lanes at the Southwest Freeway interchange under construction in 1961. In 2003 work is in progress to fill the gap between the two structures and widen the structures.";
            challengeArray[1, 5, 5] = "I06_challenge_610_interchange_at_59.jpg";
            challengeArray[1, 6, 0] = "I07_59n_1979-01-00_s_of_610_800.jpg";
            challengeArray[1, 6, 1] = "I07_59n_1979-01-00_s_of_610_2791.jpg";
            challengeArray[1, 6, 2] = "Texas Transportation Institute";
            challengeArray[1, 6, 3] = "Airport-bound motorists drove this freeway.";
            challengeArray[1, 6, 4] = "This view shows the original Eastex Freeway [US 59] just south of Loop 610. Expansion of this section of freeway was completed in 1998.";
            challengeArray[1, 6, 5] = "I07_challenge_59n_at_610.jpg";
            challengeArray[1, 7, 0] = "I08_gulf_freeway_at_velasco_ADJUSTED_300dpi_ADJ_800.jpg";
            challengeArray[1, 7, 1] = "";
            challengeArray[1, 7, 2] = "TxDOT";
            challengeArray[1, 7, 3] = "Look at the pier style. Does it look old?";
            challengeArray[1, 7, 4] = "This is the construction of the original Gulf Freeway at Velasco Street in 1947.";
            challengeArray[1, 7, 5] = "I08_challenge_45s_velasco.jpg";
            challengeArray[1, 8, 0] = "I09_i45_upper_deck_nb_july-84_ADJ_800.jpg";
            challengeArray[1, 8, 1] = "";
            challengeArray[1, 8, 2] = "Chuck Fuhs";
            challengeArray[1, 8, 3] = "Upper deck freeway, not HOV.";
            challengeArray[1, 8, 4] = "This is the construction of the elevated structure along the Gulf Freeway just southeast of downtown in July 1984.";
            challengeArray[1, 8, 5] = "I09_challenge_45s_upper_deck.jpg";
            challengeArray[1, 9, 0] = "I10_i45s_S_curve_close_view_july-85_ADJ_800.jpg";
            challengeArray[1, 9, 1] = "";
            challengeArray[1, 9, 2] = "Chuck Fuhs";
            challengeArray[1, 9, 3] = "University students travel here.";
            challengeArray[1, 9, 4] = "This is the reconstruction of the Gulf Freeway at Calhoun in 1985. In this photo you can see evidence of a traffic-flow pattern that was the notorious S-curve detour. [The traffic is routed on a straighter alignment in this view.] I was a young driver at the time and I remember the S curve well. Not only was it a tight curve, but there was a substantial elevation change while going through the S.";
            challengeArray[1, 9, 5] = "I10_challenge_45s_S_curve.jpg";
            challengeArray[1, 10, 0] = "I11_59s_at_bw8_400dpi_unsharp_off_ADJ_800.jpg";
            challengeArray[1, 10, 1] = "I11_59s_at_bw8_400dpi_unsharp_off_ADJ_3190.jpg";
            challengeArray[1, 10, 2] = "Texas State Archives";
            challengeArray[1, 10, 3] = "Sharpstown is visible in the distance.";
            challengeArray[1, 10, 4] = "This view looks north along the Southwest Freeway at the construction zone for the Beltway 8 interchange in 1983 or 1984. This project consisted of frontage road construction only.";
            challengeArray[1, 10, 5] = "I11_challenge_59s_at_BW8.jpg";
            challengeArray[1, 11, 0] = "I12_E7AHLC351960_800.jpg";
            challengeArray[1, 11, 1] = "I12_E7AHLC351960_1500.jpg";
            challengeArray[1, 11, 2] = "The Positive Image";
            challengeArray[1, 11, 3] = "There is now a brewery in the view of this photo.";
            challengeArray[1, 11, 4] = "This 1960 view looks north with the present-day East Freeway [then US 90, now IH 10] crossing from left to right and the interchange with Loop 610 [then Loop 137] on the right. Loop 137 was a two-lane highway and did not extend south of US 90.";
            challengeArray[1, 11, 5] = "I12_east_freeway.jpg";
            challengeArray[1, 12, 0] = "I13_gulf_freeway_at_wayside_400dpi_AUTO_ADJ_800.jpg";
            challengeArray[1, 12, 1] = "I13_gulf_freeway_at_wayside_400dpi_AUTO_ADJ_3000.jpg";
            challengeArray[1, 12, 2] = "TxDOT";
            challengeArray[1, 12, 3] = "Extending Houston's first freeway segment.";
            challengeArray[1, 12, 4] = "This is the construction of the Gulf Freeway [IH 45] overpass at Wayside around 1949. If you look at the high resolution image [click on the image], you will see something very interesting: a sign designating US 59. At the time US 59 was aligned on Wayside.";
            challengeArray[1, 12, 5] = "I13_challenge_45s_wayside.jpg";
            challengeArray[1, 13, 0] = "I14_59n_1981-08-00_orig_eastex_B_ADJ_800.jpg";
            challengeArray[1, 13, 1] = "I14_59n_1981-08-00_orig_eastex_B_ADJ_2802.jpg";
            challengeArray[1, 13, 2] = "Texas Transportation Institute";
            challengeArray[1, 13, 3] = "Reconstruction took forever.";
            challengeArray[1, 13, 4] = "This is the original Eastex Freeway [US 59] near Lauder Road in 1981. Reconstruction started in the early 1990s and was complete in 1998.";
            challengeArray[1, 13, 5] = "I14_challenge_59n_lauder.jpg";
            challengeArray[1, 14, 0] = "I15_290_const_at_dekoma_july-1976_HD102.10_800.jpg";
            challengeArray[1, 14, 1] = "";
            challengeArray[1, 14, 2] = "Chuck Fuhs";
            challengeArray[1, 14, 3] = "The freeway was built in small pieces in 5 decades.";
            challengeArray[1, 14, 4] = "This view shows the construction of the Northwest Freeway [US 290] main lanes near Dacoma in 1976.";
            challengeArray[1, 14, 5] = "I15_challenge_290_dacoma.jpg";
            challengeArray[2, 0, 0] = "A01_8N_may_1987_800.jpg";
            challengeArray[2, 0, 1] = "";
            challengeArray[2, 0, 2] = "Texas Transportation Institute";
            challengeArray[2, 0, 3] = "The grass in greener in this area.";
            challengeArray[2, 0, 4] = "This shows the partially complete North Beltway 8 just east of the North Freeway in 1987. The area is known as Greenspoint.";
            challengeArray[2, 0, 5] = "A01_challenge_8n_greenspoint.jpg";
            challengeArray[2, 1, 0] = "A02_59_45_const_noGEM__105.04_oct-72_ADJUST_800.jpg";
            challengeArray[2, 1, 1] = "A02_59_45_const_noGEM__105.04_oct-72_ADJUST_1800.jpg";
            challengeArray[2, 1, 2] = "Chuck Fuhs";
            challengeArray[2, 1, 3] = "Interstate 45 is in the view.";
            challengeArray[2, 1, 4] = "This view looks northbound along US 59 at the interchange with Interstate 45 in 1972.";
            challengeArray[2, 1, 5] = "A02_challenge_59s_at_45_1972.jpg";
            challengeArray[2, 2, 0] = "A03_290_at_6_construction_400dpi_unsharpoff_ADJ_800.jpg";
            challengeArray[2, 2, 1] = "";
            challengeArray[2, 2, 2] = "Texas State Archives";
            challengeArray[2, 2, 3] = "Cypress-bound motorists now drive this.";
            challengeArray[2, 2, 4] = "This is construction of the Northwest Freeway [US 290] at FM 1960/Highway 6.";
            challengeArray[2, 2, 5] = "A03_challenge_290_6.jpg";
            challengeArray[2, 3, 0] = "A04_cc_katy_diversion_360dpi_bw_no_unsharp_800.jpg";
            challengeArray[2, 3, 1] = "A04_cc_katy_diversion_360dpi_bw_no_unsharp_2700.jpg";
            challengeArray[2, 3, 2] = "Greater Houston Partnership";
            challengeArray[2, 3, 3] = "In 2003, mega-congestion just ahead.";
            challengeArray[2, 3, 4] = "This circa-1963 view looks west along the Katy Freeway [IH-10] from one of the ramps at the interchange with Loop 610. Notice that the eastbound traffic was diverted off the freeway to a temporary roadway that continues on the right side of the photo [but is not visible in this photo]. Demolition and reconstruction of this interchange is just underway in 2003.";
            challengeArray[2, 3, 5] = "A04_challenge_10w_at_610.jpg";
            challengeArray[2, 4, 0] = "A05_610s_at_288_oct-1975_HD101.01_noGEM_CROP_ADJ_800.jpg";
            challengeArray[2, 4, 1] = "";
            challengeArray[2, 4, 2] = "Chuck Fuhs";
            challengeArray[2, 4, 3] = "Motorists going to or from the Astrodome saw this.";
            challengeArray[2, 4, 4] = "This is construction of the interchange at Loop 610 and the South Freeway [SH 288] in October 1975.";
            challengeArray[2, 4, 5] = "A05_challenge_610_288.jpg";
            challengeArray[2, 5, 0] = "A06_N3BHLA5371959_800.jpg";
            challengeArray[2, 5, 1] = "";
            challengeArray[2, 5, 2] = "The Postitive Image";
            challengeArray[2, 5, 3] = "Many billboards rose along this freeway.";
            challengeArray[2, 5, 4] = "This view looks northbound along the North Freeway just south of Shepherd in 1959.";
            challengeArray[2, 5, 5] = "A06_challenge_45n_shepherd.jpg";
            challengeArray[2, 6, 0] = "A07_cc_gulf_looking_s_300dpi_color_no_unsharp_ADJ_800.jpg";
            challengeArray[2, 6, 1] = "A07_cc_gulf_looking_s_300dpi_color_no_unsharp_ADJ_2800.jpg";
            challengeArray[2, 6, 2] = "TxDOT";
            challengeArray[2, 6, 3] = "A mall was built just to the right of this photo.";
            challengeArray[2, 6, 4] = "This view looks south along the Gulf Freeway at the location of the intersection with the future South Loop. At the time, the highway veering eastward was known as the La Porte Cutoff. Gulfgate mall was built on the right side of the photo in 1956. The mall was demolished in 2001.";
            challengeArray[2, 6, 5] = "A07_challenge_45s_gulfgate.jpg";
            challengeArray[2, 7, 0] = "A08_59n_610_D_ADJUSTED_CROPPED_ADJ_800.jpg";
            challengeArray[2, 7, 1] = "A08_59n_610_D_ADJUSTED_CROPPED_ADJ_3400.jpg";
            challengeArray[2, 7, 2] = "TxDOT";
            challengeArray[2, 7, 3] = "Going under a loop. The smokestack structure no longer exists.";
            challengeArray[2, 7, 4] = "This 1973 view looks southbound along the Eastex Freeway [US 59] with the Loop 137 [now Kelley Road] overpass just ahead. The Kelley Road overpass was replaced with a new structure after the opening of the North Loop 610 in 1975. The freeway main lane reconstruction was completed in 1998.";
            challengeArray[2, 7, 5] = "A08_challenge_59n_kelley_on_freeway.jpg";
            challengeArray[2, 8, 0] = "A09_59_610_aerial_300dpi_ADJUSTED_ADJ_800.jpg";
            challengeArray[2, 8, 1] = "A09_59_610_aerial_300dpi_ADJUSTED_ADJ_2700.jpg";
            challengeArray[2, 8, 2] = "TxDOT";
            challengeArray[2, 8, 3] = "Houston's first 4-level interchange.";
            challengeArray[2, 8, 4] = "This 1960 view looks southeast across the construction zone for the interchange at the West Loop 610 and the Southwest Freeway [US 59].";
            challengeArray[2, 8, 5] = "A09_challenge_59s_at_610_aerial.jpg";
            challengeArray[2, 9, 0] = "A10_N2BHLNH5361959_800.jpg";
            challengeArray[2, 9, 1] = "A10_N2BHLNH5361959_1260.jpg";
            challengeArray[2, 9, 2] = "The Postive Image";
            challengeArray[2, 9, 3] = "A mall was built on the vacant land.";
            challengeArray[2, 9, 4] = "This 1959 view looks northbound along the North Freeway [IH 45] just north of Loop 610. Northline Mall was built on the vacant land.";
            challengeArray[2, 9, 5] = "A10_challenge_45n_airline.jpg";
            challengeArray[2, 10, 0] = "A11_45s_at_610_ramp_const_nov-77_HD100.07_GEM2_800.jpg";
            challengeArray[2, 10, 1] = "";
            challengeArray[2, 10, 2] = "Chuck Fuhs";
            challengeArray[2, 10, 3] = "Beach-bound motorists saw this.";
            challengeArray[2, 10, 4] = "This is the construction of a ramp at the interchange of the Gulf Freeway [IH 45] and the South Loop 610 in November 1977. I remember driving through this interchange construction zone [as a passenger, of course] when I was a kid.";
            challengeArray[2, 10, 5] = "A11_challenge_45s_610_ramp.jpg";
            challengeArray[2, 11, 0] = "A12_04_bw8_at_buffalo_bayou_800.jpg";
            challengeArray[2, 11, 1] = "";
            challengeArray[2, 11, 2] = "Allen Moradi";
            challengeArray[2, 11, 3] = "This was a controversial section of highway.";
            challengeArray[2, 11, 4] = "This is the construction of Beltway 8/Sam Houston Tollway at Buffalo Bayou circa 1986. Just ahead is the Memorial Bend subdivision. The subdivision residents protested the freeway construction starting in 1962.";
            challengeArray[2, 11, 5] = "A12_challenge_8_buffalo_bayou.jpg";
            challengeArray[2, 12, 0] = "A13_59s_at_sharpstown_400dpi_unsharpoff_ADJ_800.jpg";
            challengeArray[2, 12, 1] = "A13_59s_at_sharpstown_400dpi_unsharpoff_ADJ_3800.jpg";
            challengeArray[2, 12, 2] = "Houston Libary";
            challengeArray[2, 12, 3] = "The big hint in this photo is the water tower. If you look at the high resolution image, you can see a letter. The water tower was recently demolished.";
            challengeArray[2, 12, 4] = "This is the construction of the Southwest Freeway frontage roads at Bellaire Boulevard circa 1959. This view looks east, with new suburban houses in Sharpstown along Bellaire. The F&C lettering on the construction equipment stands for Farnsworth and Chambers.";
            challengeArray[2, 12, 5] = "A13_challenge_59s_bellaire.jpg";
            challengeArray[2, 13, 0] = "A14_newcastle_at_southwest_freeway_300dpi_ADJUSTED_ADJ_800.jpg";
            challengeArray[2, 13, 1] = "A14_newcastle_at_southwest_freeway_300dpi_ADJUSTED_ADJ_2700.jpg";
            challengeArray[2, 13, 2] = "TxDOT";
            challengeArray[2, 13, 3] = "The big clue in the photo is the water tower. You may need to look at the high-res image. Also, the air in the background is very nice.";
            challengeArray[2, 13, 4] = "This is Newcastle Road, looking south-southwest with the city of Bellaire in the background. The Southwest Freeway was built on the vacant land in the foreground.";
            challengeArray[2, 13, 5] = "A14_challenge_59s_newcastle.jpg";
            challengeArray[2, 14, 0] = "A15_post_oak_1950_REPAIRED_ADJ_800.jpg";
            challengeArray[2, 14, 1] = "A15_post_oak_1950_REPAIRED_ADJ_3000.jpg";
            challengeArray[2, 14, 2] = "Williams Brothers Contruction";
            challengeArray[2, 14, 3] = "Bellaire is nearby.";
            challengeArray[2, 14, 4] = "I am not certain of ths location, but it appears to be Post Oak road at Brays Bayou. The photo was taken in 1950 and is identified as Post Oak Road. The West Loop was later built at this location. I initially thought this was the Buffalo Bayou crossing, but after studying the photo I concluded it had to be Brays Bayou. Post Oak was straight at the Buffalo Bayou crossing, and I would expect to see pine trees if this was Buffalo Bayou. Also, there are some high voltage towers in the background which are not consistent with the Buffalo Bayou crossing. So it must be Brays Bayou.";
            challengeArray[2, 14, 5] = "A15_challenge_post_oak.jpg";

            return challengeArray;
        }

    }

    public class PhotoList
    {
        public PhotoList(XDocument xDoc)
        {
            photoXml = xDoc;
        }
        public XDocument photoXml {get; set;}
    }

}
