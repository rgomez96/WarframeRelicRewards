﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Items {
    public static readonly Dictionary<string, int> Ducats = new Dictionary<string, int>{
        {"AKBOLTO PRIME BLUEPRINT",15},
        {"AKBOLTO PRIME BARREL",45},
        {"AKBOLTO PRIME RECEIVER",100},
        {"AKBOLTO PRIME LINK",45},
        {"AKBRONCO PRIME BLUEPRINT",15},
        {"AKBRONCO PRIME LINK",45},
        {"AKLEX PRIME BLUEPRINT",45},
        {"AKLEX PRIME LINK",100},
        {"AKSTILETTO PRIME BLUEPRINT",100},
        {"AKSTILETTO PRIME BARREL",45},
        {"AKSTILETTO PRIME RECEIVER",45},
        {"AKSTILETTO PRIME LINK",45},
        {"ANKYROS PRIME BLUEPRINT",15},
        {"ANKYROS PRIME BLADE",65},
        {"ANKYROS PRIME GAUNTLET",15},
        {"ASH PRIME BLUEPRINT",45},
        {"ASH PRIME NEUROPTICS BLUEPRINT",45},
        {"ASH PRIME CHASSIS BLUEPRINT",15},
        {"ASH PRIME SYSTEMS BLUEPRINT",65},
        {"BALLISTICA PRIME BLUEPRINT",100},
        {"BALLISTICA PRIME LOWER LIMB",15},
        {"BALLISTICA PRIME UPPER LIMB",45},
        {"BALLISTICA PRIME RECEIVER",45},
        {"BALLISTICA PRIME STRING",45},
        {"BANSHEE PRIME BLUEPRINT",45},
        {"BANSHEE PRIME NEUROPTICS BLUEPRINT",15},
        {"BANSHEE PRIME CHASSIS BLUEPRINT",100},
        {"BANSHEE PRIME SYSTEMS BLUEPRINT",100},
        {"BO PRIME BLUEPRINT",15},
        {"BO PRIME ORNAMENT",15},
        {"BO PRIME HANDLE",45},
        {"BOAR PRIME BLUEPRINT",15},
        {"BOAR PRIME BARREL",45},
        {"BOAR PRIME RECEIVER",15},
        {"BOAR PRIME STOCK",100},
        {"BOLTOR PRIME BLUEPRINT",100},
        {"BOLTOR PRIME BARREL",15},
        {"BOLTOR PRIME RECEIVER",45},
        {"BOLTOR PRIME STOCK",15},
        {"BRATON PRIME BLUEPRINT",25},
        {"BRATON PRIME BARREL",15},
        {"BRATON PRIME RECEIVER",45},
        {"BRATON PRIME STOCK",15},
        {"BRONCO PRIME BLUEPRINT",15},
        {"BRONCO PRIME BARREL",45},
        {"BRONCO PRIME RECEIVER",15},
        {"BURSTON PRIME BLUEPRINT",15},
        {"BURSTON PRIME BARREL",45},
        {"BURSTON PRIME RECEIVER",15},
        {"BURSTON PRIME STOCK",15},
        {"CARRIER PRIME BLUEPRINT",15},
        {"CARRIER PRIME CEREBRUM",65},
        {"CARRIER PRIME CARAPACE",15},
        {"CARRIER PRIME SYSTEMS",15},
        {"CERNOS PRIME BLUEPRINT",45},
        {"CERNOS PRIME LOWER LIMB",100},
        {"CERNOS PRIME UPPER LIMB",15},
        {"CERNOS PRIME GRIP",15},
        {"CERNOS PRIME STRING",45},
        {"DAKRA PRIME BLUEPRINT",45},
        {"DAKRA PRIME BLADE",65},
        {"DAKRA PRIME HANDLE",15},
        {"DUAL KAMAS PRIME BLUEPRINT",15},
        {"DUAL KAMAS PRIME BLADE",100},
        {"DUAL KAMAS PRIME HANDLE",45},
        {"EMBER PRIME BLUEPRINT",100},
        {"EMBER PRIME NEUROPTICS BLUEPRINT",15},
        {"EMBER PRIME CHASSIS BLUEPRINT",15},
        {"EMBER PRIME SYSTEMS BLUEPRINT",45},
        {"EUPHONA PRIME BLUEPRINT",15},
        {"EUPHONA PRIME BARREL",45},
        {"EUPHONA PRIME RECEIVER",100},
        {"FANG PRIME BLUEPRINT",15},
        {"FANG PRIME BLADE",15},
        {"FANG PRIME HANDLE",25},
        {"FRAGOR PRIME BLUEPRINT",65},
        {"FRAGOR PRIME HEAD",15},
        {"FRAGOR PRIME HANDLE",65},
        {"FROST PRIME BLUEPRINT",100},
        {"FROST PRIME NEUROPTICS BLUEPRINT",15},
        {"FROST PRIME CHASSIS BLUEPRINT",15},
        {"FROST PRIME SYSTEMS BLUEPRINT",45},
        {"GALATINE PRIME BLUEPRINT",100},
        {"GALATINE PRIME BLADE",15},
        {"GALATINE PRIME HANDLE",45},
        {"GLAIVE PRIME BLUEPRINT",100},
        {"GLAIVE PRIME BLADE",45},
        {"GLAIVE PRIME DISC",45},
        {"HELIOS PRIME BLUEPRINT",45},
        {"HELIOS PRIME CEREBRUM",100},
        {"HELIOS PRIME CARAPACE",15},
        {"HELIOS PRIME SYSTEMS",45},
        {"HIKOU PRIME BLUEPRINT",15},
        {"HIKOU PRIME STARS",15},
        {"HIKOU PRIME POUCH",15},
        {"HYDROID PRIME BLUEPRINT",45},
        {"HYDROID PRIME NEUROPTICS BLUEPRINT",45},
        {"HYDROID PRIME CHASSIS BLUEPRINT",15},
        {"HYDROID PRIME SYSTEMS BLUEPRINT",100},
        {"KAVASA PRIME COLLAR BLUEPRINT",45},
        {"KAVASA PRIME BAND",45},
        {"KAVASA PRIME BUCKLE",65},
        {"KOGAKE PRIME BLUEPRINT",45},
        {"KOGAKE PRIME GAUNTLET",100},
        {"KOGAKE PRIME BOOT",15},
        {"KRONEN PRIME BLUEPRINT",15},
        {"KRONEN PRIME BLADE",100},
        {"KRONEN PRIME HANDLE",45},
        {"LATRON PRIME BLUEPRINT",15},
        {"LATRON PRIME BARREL",15},
        {"LATRON PRIME RECEIVER",15},
        {"LATRON PRIME STOCK",15},
        {"LEX PRIME BLUEPRINT",25},
        {"LEX PRIME BARREL",15},
        {"LEX PRIME RECEIVER",15},
        {"LOKI PRIME BLUEPRINT",15},
        {"LOKI PRIME NEUROPTICS BLUEPRINT",15},
        {"LOKI PRIME CHASSIS BLUEPRINT",45},
        {"LOKI PRIME SYSTEMS BLUEPRINT",100},
        {"MAG PRIME BLUEPRINT",100},
        {"MAG PRIME NEUROPTICS BLUEPRINT",15},
        {"MAG PRIME CHASSIS BLUEPRINT",45},
        {"MAG PRIME SYSTEMS BLUEPRINT",15},
        {"MIRAGE PRIME BLUEPRINT",100},
        {"MIRAGE PRIME NEUROPTICS BLUEPRINT",15},
        {"MIRAGE PRIME CHASSIS BLUEPRINT",15},
        {"MIRAGE PRIME SYSTEMS BLUEPRINT",45},
        {"NAMI SKYLA PRIME BLUEPRINT",15},
        {"NAMI SKYLA PRIME BLADE",100},
        {"NAMI SKYLA PRIME HANDLE",45},
        {"NEKROS PRIME BLUEPRINT",100},
        {"NEKROS PRIME NEUROPTICS BLUEPRINT",45},
        {"NEKROS PRIME CHASSIS BLUEPRINT",15},
        {"NEKROS PRIME SYSTEMS BLUEPRINT",100},
        {"NIKANA PRIME BLUEPRINT",65},
        {"NIKANA PRIME BLADE",100},
        {"NIKANA PRIME HILT",100},
        {"NOVA PRIME BLUEPRINT",45},
        {"NOVA PRIME NEUROPTICS BLUEPRINT",15},
        {"NOVA PRIME CHASSIS BLUEPRINT",100},
        {"NOVA PRIME SYSTEMS BLUEPRINT",15},
        {"NYX PRIME BLUEPRINT",15},
        {"NYX PRIME NEUROPTICS BLUEPRINT",100},
        {"NYX PRIME CHASSIS BLUEPRINT",100},
        {"NYX PRIME SYSTEMS BLUEPRINT",45},
        {"OBERON PRIME BLUEPRINT",45},
        {"OBERON PRIME NEUROPTICS BLUEPRINT",100},
        {"OBERON PRIME CHASSIS BLUEPRINT",15},
        {"OBERON PRIME SYSTEMS BLUEPRINT",100},
        {"ODONATA PRIME BLUEPRINT",45},
        {"ODONATA PRIME HARNESS BLUEPRINT",15},
        {"ODONATA PRIME WINGS BLUEPRINT",65},
        {"ODONATA PRIME SYSTEMS BLUEPRINT",15},
        {"ORTHOS PRIME BLUEPRINT",45},
        {"ORTHOS PRIME BLADE",45},
        {"ORTHOS PRIME HANDLE",15},
        {"PARIS PRIME BLUEPRINT",15},
        {"PARIS PRIME LOWER LIMB",15},
        {"PARIS PRIME UPPER LIMB",25},
        {"PARIS PRIME GRIP",45},
        {"PARIS PRIME STRING",15},
        {"REAPER PRIME BLUEPRINT",15},
        {"REAPER PRIME BLADE",45},
        {"REAPER PRIME HANDLE",15},
        {"RHINO PRIME BLUEPRINT",100},
        {"RHINO PRIME NEUROPTICS BLUEPRINT",45},
        {"RHINO PRIME CHASSIS BLUEPRINT",65},
        {"RHINO PRIME SYSTEMS BLUEPRINT",15},
        {"SARYN PRIME BLUEPRINT",65},
        {"SARYN PRIME NEUROPTICS BLUEPRINT",45},
        {"SARYN PRIME CHASSIS BLUEPRINT",100},
        {"SARYN PRIME SYSTEMS BLUEPRINT",15},
        {"SCINDO PRIME BLUEPRINT",45},
        {"SCINDO PRIME BLADE",100},
        {"SCINDO PRIME HANDLE",45},
        {"SICARUS PRIME BLUEPRINT",15},
        {"SICARUS PRIME BARREL",15},
        {"SICARUS PRIME RECEIVER",100},
        {"SILVA & AEGIS PRIME BLUEPRINT",45},
        {"SILVA & AEGIS PRIME BLADE",45},
        {"SILVA & AEGIS PRIME HILT",15},
        {"SILVA & AEGIS PRIME GUARD",100},
        {"SOMA PRIME BLUEPRINT",15},
        {"SOMA PRIME BARREL",15},
        {"SOMA PRIME RECEIVER",45},
        {"SOMA PRIME STOCK",100},
        {"SPIRA PRIME BLUEPRINT",15},
        {"SPIRA PRIME BLADE",100},
        {"SPIRA PRIME POUCH",100},
        {"SYBARIS PRIME BLUEPRINT",15},
        {"SYBARIS PRIME BARREL",100},
        {"SYBARIS PRIME RECEIVER",45},
        {"SYBARIS PRIME STOCK",15},
        {"TIBERON PRIME BLUEPRINT",45},
        {"TIBERON PRIME BARREL",100},
        {"TIBERON PRIME RECEIVER",15},
        {"TIBERON PRIME STOCK",100},
        {"TIGRIS PRIME BLUEPRINT",100},
        {"TIGRIS PRIME BARREL",45},
        {"TIGRIS PRIME RECEIVER",45},
        {"TIGRIS PRIME STOCK",15},
        {"TRINITY PRIME BLUEPRINT",45},
        {"TRINITY PRIME NEUROPTICS BLUEPRINT",25},
        {"TRINITY PRIME CHASSIS BLUEPRINT",45},
        {"TRINITY PRIME SYSTEMS BLUEPRINT",15},
        {"VALKYR PRIME BLUEPRINT",15},
        {"VALKYR PRIME NEUROPTICS BLUEPRINT",45},
        {"VALKYR PRIME CHASSIS BLUEPRINT",100},
        {"VALKYR PRIME SYSTEMS BLUEPRINT",100},
        {"VASTO PRIME BLUEPRINT",45},
        {"VASTO PRIME BARREL",15},
        {"VASTO PRIME RECEIVER",15},
        {"VAUBAN PRIME BLUEPRINT",100},
        {"VAUBAN PRIME NEUROPTICS BLUEPRINT",100},
        {"VAUBAN PRIME CHASSIS BLUEPRINT",100},
        {"VAUBAN PRIME SYSTEMS BLUEPRINT",100},
        {"VECTIS PRIME BLUEPRINT",45},
        {"VECTIS PRIME BARREL",15},
        {"VECTIS PRIME RECEIVER",100},
        {"VECTIS PRIME STOCK",65},
        {"VENKA PRIME BLUEPRINT",45},
        {"VENKA PRIME BLADES",15},
        {"VENKA PRIME GAUNTLET",100},
        {"VOLT PRIME BLUEPRINT",25},
        {"VOLT PRIME NEUROPTICS BLUEPRINT",65},
        {"VOLT PRIME CHASSIS BLUEPRINT",45},
        {"VOLT PRIME SYSTEMS BLUEPRINT",45},
        {"WYRM PRIME BLUEPRINT",15},
        {"WYRM PRIME CEREBRUM",15},
        {"WYRM PRIME CARAPACE",15},
        {"WYRM PRIME SYSTEMS",45},
        {"ZEPHYR PRIME BLUEPRINT",100},
        {"ZEPHYR PRIME NEUROPTICS BLUEPRINT",15},
        {"ZEPHYR PRIME CHASSIS BLUEPRINT",45},
        {"ZEPHYR PRIME SYSTEMS BLUEPRINT",100},
        {"FORMA BLUEPRINT", 0}
};

    public static readonly string[] Names = Ducats.Select(item => item.Key).ToArray();

    public static readonly int[][] IntNames = Names.Select(name => EditDistance.toIntArray(name)).ToArray();

    private static readonly string[] Warframes = new string[] {
        "ASH", "ATLAS", "BANSHEE", "CHROMA", "EMBER", "EQUINOX", "EXCALIBUR",
        "FROST", "GARA", "HARROW", "HYDROID", "INAROS", "IVARA", "LIMBO",
        "LOKI", "MAG", "MESA", "MIRAGE", "NEKROS", "NEZHA", "NIDUS", "NOVA",
        "NYX", "OBERON", "OCTAVIA", "RHINO", "SARYN", "TITANIA", "TRINITY",
        "VALKYR", "VAUBAN", "VOLT", "WUKONG", "ZEPHYR" };

    private static readonly Regex warframeRegex = new Regex("((?:ASH|ATLAS|BANSHEE|CHROMA|EMBER|EQUINOX|EXCALIBUR|FROST|GARA|HARROW|HYDROID|INAROS|IVARA|LIMBO|LOKI|MAG|MESA|MIRAGE|NEKROS|NEZHA|NIDUS|NOVA|NYX|OBERON|OCTAVIA|RHINO|SARYN|TITANIA|TRINITY|VALKYR|VAUBAN|VOLT|WUKONG|ZEPHYR|ODONATA) PRIME (?:CHASSIS|SYSTEMS|NEUROPTICS|WINGS|HARNESS)) BLUEPRINT");

    public static string Normalize(string name) {
        var m = warframeRegex.Match(name);
        if (m.Success) {
            return m.Groups[1].ToString();
        }
        return name;
    }
}