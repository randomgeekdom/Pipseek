namespace Pipseek.Services
{
    public static class RandomPictureEmbedder
    {
        private static readonly List<string> list = new List<string>{
            "<a title=\"©Frank Schulenburg\" href=\"https://commons.wikimedia.org/wiki/File:Alocasia_cuprea_(portrait_orientation).jpg\"><img width=\"256\" alt=\"Alocasia cuprea (portrait orientation)\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Alocasia_cuprea_%28portrait_orientation%29.jpg/256px-Alocasia_cuprea_%28portrait_orientation%29.jpg\"></a>",

            "<a title=\"Holly (Ilex aquifolium), St Aldhelm&#039;s Church by Maigheach-gheal, CC BY-SA 2.0 &lt;https://creativecommons.org/licenses/by-sa/2.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Holly_(Ilex_aquifolium),_St_Aldhelm%27s_Church_-_geograph.org.uk_-_2136950.jpg\"><img width=\"512\" alt=\"Holly (Ilex aquifolium), St Aldhelm&#039;s Church - geograph.org.uk - 2136950\" src=\"https://upload.wikimedia.org/wikipedia/commons/c/c8/Holly_%28Ilex_aquifolium%29%2C_St_Aldhelm%27s_Church_-_geograph.org.uk_-_2136950.jpg\"></a>",

            "<a title=\"JonRichfield, CC BY-SA 4.0 &lt;https://creativecommons.org/licenses/by-sa/4.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Brazil_nut_Seed_Tegmen_testa.jpg\"><img width=\"512\" alt=\"Brazil nut Seed Tegmen testa\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Brazil_nut_Seed_Tegmen_testa.jpg/512px-Brazil_nut_Seed_Tegmen_testa.jpg\"></a>",

            "<a title=\"LadyofHats, Public domain, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Avocado_seed_diagram-en.svg\"><img width=\"512\" alt=\"Avocado seed diagram-en\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Avocado_seed_diagram-en.svg/512px-Avocado_seed_diagram-en.svg.png\"></a>",

            "<a title=\"MathKnight, CC BY-SA 4.0 &lt;https://creativecommons.org/licenses/by-sa/4.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Flowers-of-Israel-ver006.jpg\"><img width=\"512\" alt=\"Flowers-of-Israel-ver006\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Flowers-of-Israel-ver006.jpg/512px-Flowers-of-Israel-ver006.jpg\"></a>",

            "<a title=\"Trachemys, CC BY-SA 3.0 &lt;https://creativecommons.org/licenses/by-sa/3.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Blossom_of_Mirabelle_plum_(cropped_transparent).png\"><img width=\"512\" alt=\"Blossom of Mirabelle plum (cropped transparent)\" src=\"https://upload.wikimedia.org/wikipedia/commons/7/77/Blossom_of_Mirabelle_plum_%28cropped_transparent%29.png\"></a>",

            "<a title=\"From My Easy Decoration, CC BY-SA 4.0 &lt;https://creativecommons.org/licenses/by-sa/4.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Names_Of_Flowers_In_Spring_Season.jpg\"><img width=\"512\" alt=\"Names Of Flowers In Spring Season\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Names_Of_Flowers_In_Spring_Season.jpg/512px-Names_Of_Flowers_In_Spring_Season.jpg\"></a>",

            "<a title=\"Our World In Data, CC BY 3.0 &lt;https://creativecommons.org/licenses/by/3.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Vegetable_consumption_per_capita_2017,_OWID.svg\"><img width=\"512\" alt=\"Vegetable consumption per capita 2017, OWID\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Vegetable_consumption_per_capita_2017%2C_OWID.svg/512px-Vegetable_consumption_per_capita_2017%2C_OWID.svg.png\"></a>",

            "<a title=\"Hari Prasad Nadig from Bangalore, India, CC BY-SA 2.0 &lt;https://creativecommons.org/licenses/by-sa/2.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Alangium_decapetalum_herbs_and_spices_of_India.jpg\"><img width=\"512\" alt=\"Alangium decapetalum herbs and spices of India\" src=\"https://upload.wikimedia.org/wikipedia/commons/c/c5/Alangium_decapetalum_herbs_and_spices_of_India.jpg\"></a>",

            "<a title=\"Si Griffiths, CC BY-SA 3.0 &lt;https://creativecommons.org/licenses/by-sa/3.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Mountain_Witch_Alder_(Fothergilla_major)_Shrub_In_Flower_Hampshire_UK.jpg\"><img width=\"512\" alt=\"Mountain Witch Alder (Fothergilla major) Shrub In Flower Hampshire UK\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Mountain_Witch_Alder_%28Fothergilla_major%29_Shrub_In_Flower_Hampshire_UK.jpg/512px-Mountain_Witch_Alder_%28Fothergilla_major%29_Shrub_In_Flower_Hampshire_UK.jpg\"></a>",

            "<a title=\"A splash of colour by Eirian Evans, CC BY-SA 2.0 &lt;https://creativecommons.org/licenses/by-sa/2.0&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:A_splash_of_colour_-_geograph.org.uk_-_1830668.jpg\"><img width=\"512\" alt=\"A splash of colour - geograph.org.uk - 1830668\" src=\"https://upload.wikimedia.org/wikipedia/commons/b/b0/A_splash_of_colour_-_geograph.org.uk_-_1830668.jpg\"></a>",

            "<a title=\"Alvesgaspar, CC BY-SA 3.0 &lt;http://creativecommons.org/licenses/by-sa/3.0/&gt;, via Wikimedia Commons\" href=\"https://commons.wikimedia.org/wiki/File:Hortensia-1.jpg\"><img width=\"512\" alt=\"Hortensia-1\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Hortensia-1.jpg/512px-Hortensia-1.jpg\"></a>"
            };

        public static string GetEmbeddedElement()
        {
            return list.OrderBy(x => Guid.NewGuid()).First();
        }
    }
}
