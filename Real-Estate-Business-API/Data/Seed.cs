using Real_Estate_Business_API.Models;
using System;

namespace Real_Estate_Business_API.Data
{
    public class Seed
    {
        public static async void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Houses.Any())
                {
                    var SingleFamily = new HouseType { Type = "SingleFamily", };
                    var Condo = new HouseType { Type = "Condo" };

                    var houses = new List<House>
                    {
                        // Malibu
                        new House
                        {
                            Name = "Shirley MacLaine's Coastal Retreat",
                            Bedrooms = 2,
                            Bathroom = 2,
                            Area = 1182,
                            Description = "Experience the best of coastal living with this exclusive beachfront condominium on Malibu Road. The building was built and designed by actress Shirley MacLaine in collaboration with renowned architect Cliff May. This charming two-bedroom, two-bath corner unit is one of only six in the building. Enjoy coastline whitewater views by day and enchanting city lights by night. The generous primary suite includes a spa tub for ultimate relaxation, and the open kitchen features granite countertops and stainless-steel appliances to inspire your culinary delights. Nestled on a tranquil, sandy beach, this paradise includes an oceanfront balcony for you to enjoy the serene ambiance. The building features a peaceful center courtyard and the convenience of a one-car garage with additional tandem parking. Known as one of the best buildings on the \"Old Road\", this unit is your ideal beachside pied-a-terre, offering an escape from the heat and bustle of city life. Make this slice of Malibu beach your own and enjoy a lifestyle of peace and relaxation. Don't miss out on this unique opportunity to own a truly special retreat!",
                            Details = "This exclusive two-bedroom, two-bath beachfront condominium on Malibu Road, designed by Shirley MacLaine and architect Cliff May, offers stunning coastline views and a serene, sandy beach setting. With a spa tub, open kitchen with granite countertops, and an oceanfront balcony, this peaceful unit includes a one-car garage and tandem parking, making it the perfect beachside retreat.",
                            Advert = "Discover your perfect coastal retreat with this exclusive Malibu Road beachfront condominium, designed by Shirley MacLaine and Cliff May. Enjoy stunning whitewater views, a serene beachside ambiance, and luxurious amenities in this rare two-bedroom corner unit—one of only six in the building.",
                            Quote = "Experience the best of coastal living",
                            Country = "USA",
                            State = "California",
                            City = "Malibu",
                            HouseType = Condo,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/943b11bbb164e3ad44a1896c010554d5-cc_ft_960.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/002fed905538cd7a783959d91ca5eab0-cc_ft_576.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/def0b6bcf2984aca6b9cd1a9ac731467-cc_ft_576.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/5c82bc85351c28130c214508e8c99093-cc_ft_960.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/7e60539a9a721def98ae847b129410f8-cc_ft_576.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/001db140d8dfeff0d470e125f0efb41e-cc_ft_576.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/a8630b0db9c796c013dd3611f7002755-cc_ft_960.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/493cd3b3d14398d05ed6c613af0987c1-cc_ft_576.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/2a026d5179560924a316983689de6f49-cc_ft_576.webp" },
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 78500,
                                LegalFees = 2000,
                                HomeInspection = 500,  
                                PropertyInsurance = 15696,
                                MortgageFees = 1000,
                                PropertyTaxes = 45530,
                                HomeownersAssociationFee = 750,
                                ListingPrice = 3925000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "One-level design for easy living"},
                                new FeaturesAndAmenities{ Text = "Two-story layout with spacious rooms"},
                                new FeaturesAndAmenities{ Text = "Grand foyer for a welcoming entrance"},
                                new FeaturesAndAmenities{ Text = "Living room deck for outdoor relaxation"},
                                new FeaturesAndAmenities{ Text = "Balcony and living room balcony for scenic views"},
                                new FeaturesAndAmenities{ Text = "Luxurious spa for ultimate relaxation"},
                                new FeaturesAndAmenities{ Text = "Tub with jets for a soothing experience"},
                                new FeaturesAndAmenities{ Text = "Breathtaking panoramic views"},
                            }
                        },
                        new House
                        {
                            Name = "Oceanfront Horizon",
                            Bedrooms = 3,
                            Bathroom = 3,
                            Area = 1855,
                            Description = "Stunning Oceanfront Home with Luxurious Upgrades!Welcome to your dream home, elegantly remodeled throughout and situated in a coveted gated community. This stunning oceanfront property boasts an expansive deck where you can enjoy breathtaking views of the ocean. Step into the heart of the home, a beautifully remodeled kitchen with a spacious center island, perfect for entertaining. The kitchen and family room both overlook the ocean, creating a serene backdrop for daily living. The primary bedroom offers front row ocean views and features an en-suite bathroom complete with dual vanities, a large bathtub, and a glass-enclosed shower. Upstairs, you'll find a secondary bedroom and a remodeled bathroom, ensuring comfort and style for guests or family. Additional features include a convenient downstairs bedroom and full bathroom, a laundry room, and numerous upgrades throughout the home. The gated community offers a sport court, two covered parking spaces, and access to one of the most premier surf spots at County Line/Buena Vista Beach. Experience luxury coastal living at its finest in this meticulously updated oceanfront gem.",
                            Details = "home features 3 bedrooms and 3 remodeled bathrooms, including a master suite with a walk-in closet and master bathroom. The remodeled kitchen, equipped with a kitchen island, opens to the family room, and the home also includes recessed lighting, a fireplace, and a laundry room, all within a total interior area of 1,855 sqft.",
                            Advert = "This stunning oceanfront home, elegantly remodeled and located in a gated community, offers breathtaking views, a spacious deck, and a beautifully updated kitchen. With luxurious upgrades, including a primary bedroom with ocean views, remodeled bathrooms, and access to premier surf spots, this home embodies coastal living at its finest.",
                            Quote = "Stunning Oceanfront Home",
                            Country = "USA",
                            State = "California",
                            City = "Malibu",
                            HouseType = Condo,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/4c084c65f72d8a1e364ae7d09c339783-sc_1920_1280.webp" },
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/e718483f6bf84c2048086612a4f576c2-sc_1920_1280.webp" },
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/657898206cfdd9c2f6e0f0458021af0e-sc_1920_1280.webp" },
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/73c188e37ef7e6f48bc44e767fbeaf29-sc_1920_1280.webp" },
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/a06eaf1eef8a269c7931d7b939d1f950-sc_1920_1280.webp" },
                            },
                             Pricing = new Pricing
                            {
                                PropertyTransferTax = 25000,
                                LegalFees = 1500,
                                HomeInspection = 500,
                                PropertyInsurance = 15696,
                                MortgageFees = 2000,
                                PropertyTaxes = 30789,
                                HomeownersAssociationFee = 827,
                                ListingPrice = 2799000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "Two levels of living space" },
                                new FeaturesAndAmenities{ Text = "Spacious two-story design" },
                                new FeaturesAndAmenities{ Text = "Ground level entry with steps" },
                                new FeaturesAndAmenities{ Text = "Inviting deck and patio areas" },
                                new FeaturesAndAmenities{ Text = "Stunning ocean and water views" },
                                new FeaturesAndAmenities{ Text = "Sweeping views of ocean, water, and white water" },
                                new FeaturesAndAmenities{ Text = "Direct access to beach and oceanfront" }
                            }
                        },
                        new House
                        {
                            Name = "Seaside Sanctuary",
                            Bedrooms = 5,
                            Bathroom = 6,
                            Area =  4716,
                            Description = "Experience luxury coastal living in this completely remodeled oceanfront home, set within the exclusive, gated Sea Level Drive community. This three-story residence, masterfully redesigned by the renowned Nathan Turner, offers direct beach access and showcases unparalleled ocean views from nearly every room. Inside, the main level is an entertainer's dream, featuring a spacious living room with a fireplace and drop-down TV that opens seamlessly to an outdoor patio with a cozy fire pit. The gourmet kitchen boasts high-end appliances and a stunning waterfall island looking out over the Pacific. On the second level the primary suite offers a private deck, spa-like bathroom with dual vanities, and an ocean-view steam shower for the ultimate relaxation. This floor also includes two additional en-suite bedrooms. On the lower level, you'll find two more en-suite bedrooms, along with a media room complete with custom built-in bookshelves, a ceiling-mounted projector, and a retractable screen perfect for movie nights. Nestled in the serene Sea Level Drive neighborhood, this property is a private coastal retreat, allowing you to fully embrace Malibu's beauty and tranquility.",
                            Details = "Features 5 bedrooms and 6 bathrooms, including full bathrooms. It offers a variety of rooms such as a bar, breakfast area, dining area, home theatre, master bedroom, and more, along with central heating and air conditioning. The kitchen includes high-end appliances like a barbeque, dishwasher, dryer, and refrigerator. Inside, you'll find hardwood, tile, and carpet flooring, along with four fireplaces in the living room, master bedroom, and outdoor areas. The total livable space is 4,716 sqft, with additional built-ins and sliding doors.",
                            Advert = "Experience unparalleled oceanfront luxury in this fully remodeled three-story home, offering direct beach access and stunning ocean views from nearly every room. Designed by renowned Nathan Turner, this exquisite residence features spacious living areas, a gourmet kitchen, a private primary suite, and a dedicated media room, all within the exclusive Sea Level Drive community.",
                            Quote = "Experience luxury coastal living",
                            Country = "USA",
                            State = "California",
                            City = "Malibu",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/0733156d929534ca7e001d1984cb8d93-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/187e2202404211f6f8a31021a93876f1-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/a226b1206e36d232ff86d43167128bb3-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/c6f816f85c748d1cae04aca097828f1f-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/70110fe0720b136872e16e2bfb75d0e7-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/29fb5241fc2dd7649766e2889476e719-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/a3f4be98b35ff5d72c2d07193f154e63-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/1a7c4f47d55da4334b6e2b3047fa9e52-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/eed4cf37c9e5ef8fb8dbde817e260c16-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/647b56ac2daf000de1c43d1943187e33-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/352396be6b4bfbd292640543f239ca2b-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 98500,
                                LegalFees = 3500,
                                HomeInspection = 500,
                                PropertyInsurance = 65796,
                                MortgageFees = 3000,
                                PropertyTaxes = 190820,
                                HomeownersAssociationFee = 529,
                                ListingPrice = 16450000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "Three or more levels for versatile living arrangements." },
                                new FeaturesAndAmenities{ Text = "Spacious three-story design offering ample room." },
                                new FeaturesAndAmenities{ Text = "Balcony for enjoying scenic outdoor views." },
                                new FeaturesAndAmenities{ Text = "Barbecue area for outdoor cooking and entertaining." },
                                new FeaturesAndAmenities{ Text = "Rain gutters for efficient water drainage." },
                                new FeaturesAndAmenities{ Text = "No pool features included." },
                                new FeaturesAndAmenities{ Text = "Relaxing spa available for private use." },
                                new FeaturesAndAmenities{ Text = "Above-ground spa heated with gas for year-round comfort." },
                                new FeaturesAndAmenities{ Text = "Private spa setup for exclusive relaxation." },
                                new FeaturesAndAmenities{ Text = "Panoramic views including Catalina, coastline, and mountains." },
                                new FeaturesAndAmenities{ Text = "Expansive water views featuring Catalina and white water." },
                                new FeaturesAndAmenities{ Text = "Direct ocean access for waterfront enjoyment." },
                                new FeaturesAndAmenities{ Text = "Picturesque waterfront location with breathtaking views." }
                            }
                        },
                        new House
                        {
                            Name = "Malibu Park Estate",
                            Bedrooms = 6,
                            Bathroom = 6,
                            Area = 5082,
                            Description = "Nestled in Malibu Park, this stunning 2.5-acre estate offers unmatched privacy and coastal living. Enclosed in a lush, park-like setting with a pool/spa, lawns, mature trees, and a private orchard, the property features a modern ranch home with luxury finishes, including wood floors, vaulted beamed ceilings, and quartzite countertops. The open-concept design boasts spacious living and entertaining areas, a chef's kitchen, and seamless indoor-outdoor flow to balconies and a backyard deck. \r\n\r\nThe primary suite occupies the upper floor, featuring a fireplace, vaulted ceilings, and a spa-like en-suite with a soaking tub and walk-in closet. Additional highlights include a guest studio with private access, ample parking, and a 3-car garage with EV charging. Minutes from Zuma Beach, this retreat combines elegance, convenience, and the essence of Malibu living.",
                            Details = "his luxurious home features 6 bedrooms, 6 bathrooms (including 5 full and 1 half bath), and a spacious interior with 5,082 square feet of livable area. It offers a variety of rooms, including a bonus room, office, dining area, and family room, along with modern amenities such as central heating and cooling, a central vacuum system, and built-in features.",
                            Advert = "Situated in the coastal oasis of Malibu Park, this extraordinary estate spans over 2.5 lush acres with unparalleled privacy, offering a modern ranch home surrounded by a pool/spa, sprawling lawns, mature trees, and a private orchard. Featuring luxurious finishes, seamless indoor-outdoor living, and a prime location minutes from Zuma Beach, it’s the ultimate retreat for those seeking privacy, elegance, and the essence of Malibu living.",
                            Quote = "Situated in the coastal oases",
                            Country = "USA",
                            State = "California",
                            City = "Malibu",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/4c2acc64c44ffa8a7f3e61855e72af1d-cc_ft_960.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/1390b2f226a57025d12077c61a33966e-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/d9950f0614388674b2878005e30f7b3e-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/258d72b1c07e3a49dc020ab240cdc2be-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/f406b3a9a021d267939eb7ca6d795b6a-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6edf3be2f02fc2de78ebcba349a5b820-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6deb7d836995b2c5bb007435028f1ec2-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/db8720944ac717bd9ffc01ba65dc5856-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 172500,
                                LegalFees = 25000,
                                HomeInspection = 5000,
                                PropertyInsurance = 23004,
                                MortgageFees = 115000,
                                PropertyTaxes = 66700,
                                HomeownersAssociationFee = null,
                                ListingPrice = 5750000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities { Text = "Multi-level split design for dynamic living spaces." },
                                new FeaturesAndAmenities { Text = "Three-story layout for spacious living." },
                                new FeaturesAndAmenities { Text = "In-ground pool for relaxing and recreation." },
                                new FeaturesAndAmenities { Text = "In-ground spa for ultimate relaxation." },
                                new FeaturesAndAmenities { Text = "Breathtaking views of canyons, mountains, and treetops." },
                                new FeaturesAndAmenities { Text = "Scenic poolside and orchard vistas." },
                                new FeaturesAndAmenities { Text = "Panoramic views of wooded hills and serene landscapes." },
                                new FeaturesAndAmenities { Text = "Picturesque water views for a tranquil experience." },
                            }
                        },
                        new House
                        {
                            Name = "Paradise Cove Estate",
                            Bedrooms = 6,
                            Bathroom = 8,
                            Area = 8775,
                            Description = "A rare, oceanfront estate in Paradise Cove with a private beach path. A gated driveway winds through an olive grove to a Marc Appleton-designed home inspired by Mykonos, with thick plaster walls, breathtaking scale, and village-like architecture. Perched by the sea, it features domed and vaulted roofs, tall chimneys, and stunning Pacific views. Highlights include a grand living room, media room, formal dining, gourmet kitchen, and a luxurious primary suite with a private terrace. Additional features: three fireplaces in guest rooms, a guest house, staff quarters, tennis court, pool, and a beachside bar. Shown to prequalified buyers only.",
                            Details = "This property includes 6 bedrooms and 8 bathrooms, with 7 full bathrooms and 1 half bathroom. It offers a variety of rooms such as a bar, media room, family room, dining room, and master bedroom, with central heating and cooling, and features built-in appliances like a dishwasher, refrigerator, and washer/dryer. The total interior livable area is 8,775 sqft, and the flooring is wood with fireplaces in the master bedroom and another room.",
                            Advert = "A once-in-a-generation oceanfront estate in Paradise Cove, designed by Marc Appleton, offers a Mykonos-inspired retreat with a private path to the beach. This stunning property features a main house with breathtaking ocean views, luxurious amenities, a guest house, staff quarters, a tennis court, a resort-like pool, and a private beach bar on the sand, accessible to prequalified clients only.",
                            Quote = "Paradise Cove’s oceanfront masterpiece",
                            Country = "USA",
                            State = "California",
                            City = "Malibu",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/16e8890d9390f643e12d345663a4ea35-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/4973d806c44dc7fa0d6555bc86196eac-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/636efd7cb31b2b0cb6e27e020aafdd29-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/66b1ea28ac97141d88474963e87d1d95-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/0d6010bb3ab6adb1e260abf6b2fce1f4-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/9f14b961faf9287417b68254374e8594-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/507790938c94c1f4e59d628b285e9077-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/d92dcbf373885817d1b311cf4cf49857-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6e5ccde08d6a8a3658781ebde501a1f7-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/90bc5dbf484b2fd06df782a147a2f39a-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/2cab80d7765b2a8b7850c31c3931b6a6-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/9df62e158ccb254f988b726fac8cfcfa-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/4bd02ff28790369a02a370dd59d66b37-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 500000,
                                LegalFees = 200000,
                                HomeInspection = 150000,
                                PropertyInsurance = 339996,
                                MortgageFees = 50000,
                                PropertyTaxes = 986000,
                                HomeownersAssociationFee = null,
                                ListingPrice = 85000000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "Two-level design with two stories" },
                                new FeaturesAndAmenities{ Text = "Private in-ground pool" },
                                new FeaturesAndAmenities{ Text = "Private spa" },
                                new FeaturesAndAmenities{ Text = "Panoramic coastline and ocean views" },
                                new FeaturesAndAmenities{ Text = "Waterfront views of coastline and ocean" },
                            }
                        },

                        //Los Angeles
                        new House
                        {
                            Name = "The Angelo Estate",
                            Bedrooms = 16,
                            Bathroom = 27,
                            Area = 50000,
                            Description = "The Angelo Estate, designed by renowned architect Ed Tuttle, is one of America's most spectacular contemporary estates. Perched on a private 6-acre promontory, it offers panoramic views of the Los Angeles basin from downtown to the ocean. The steel, glass, and limestone masterpiece features a gated driveway, parking for 80-100 cars, and a central open courtyard with fountains. Inside, the light-filled atrium evokes IM Pei’s Louvre, with soaring ceilings, art-ready walls, and luxurious spaces, including a living room, dining room, library, gourmet kitchen, theatre, bowling alley, wellness center, and wine cellar. \r\n\r\nCrafted with Italian limestone and white oak, the home boasts cutting-edge geothermal heating, solar panels, and advanced security. The estate includes a green marble infinity pool, spa, outdoor kitchen, tennis court, lush gardens, a 2-story guest house, and a separate apartment. With 16 bedrooms, 27 bathrooms, and 18 fireplaces, this private peninsula property offers unparalleled luxury and views. Shown to pre-qualified buyers only.",
                            Details = "This luxurious property boasts 16 spacious bedrooms and 27 bathrooms, including 16 full bathrooms and 11 half baths, with features such as two master baths, walk-in closets, and a master retreat, all spanning an impressive 50,000 square feet of interior living space.",
                            Advert = "Experience unparalleled luxury at The Angelo Estate, a breathtaking architectural masterpiece by Ed Tuttle, perched on a 6-acre promontory with sweeping views of Los Angeles from downtown to the ocean. Featuring 16 bedrooms, 27 bathrooms, a green marble infinity pool, and world-class amenities, this one-of-a-kind estate offers unmatched elegance and exclusivity.",
                            Quote = "Unmatched luxury, views, and design",
                            Country = "USA",
                            State = "California",
                            City = "Los Angeles",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6156ec1b0682986522be5230fb575a51-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/0fb4cd14c3ad9785b408b257617d2a81-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/d8ce74949daef4d2b80d69ac8d5ade65-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/9c72ec9de16efd4b93b4b5cf82fbc1fb-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/e07c057eab9b02be63f7d5f5ed836dde-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/f743396dba84e58dd32902aafc5a4742-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6598d3ec93f3605a8482c819da05464c-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/c7e937a8ad2c91c01534f64b2bedeba9-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 975000,
                                LegalFees = 500000,
                                HomeInspection = 100000,
                                PropertyInsurance = 780000,
                                MortgageFees = 1950000,
                                PropertyTaxes = 2262000,
                                HomeownersAssociationFee = null,
                                ListingPrice = 195000000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities { Text = "Three or more levels for spacious living." },
                                new FeaturesAndAmenities { Text = "Three-story design for multi-level luxury." },
                                new FeaturesAndAmenities { Text = "Elevator entry for convenient access." },
                                new FeaturesAndAmenities { Text = "Covered porch for shaded relaxation." },
                                new FeaturesAndAmenities { Text = "Living room deck attached for seamless indoor-outdoor flow." },
                                new FeaturesAndAmenities { Text = "Expansive patio for outdoor enjoyment." },
                                new FeaturesAndAmenities { Text = "Rooftop deck with breathtaking views." },
                                new FeaturesAndAmenities { Text = "Private balcony for serene escapes." },
                            }
                        },
                        new House
                        {
                            Name = "Boathouse Ridge",
                            Bedrooms = 3,
                            Bathroom = 3,
                            Area = 2380,
                            Description = "Designed by acclaimed architect Harry Gesner, this three-level Norwegian Boathouse is a mid-century gem perched atop the Hollywood Hills. Part of Gesner's iconic portfolio, which includes the Malibu Wave House, Steel House, and Ravenseye, this 2,400 sq ft home showcases futuristic design elements like a dramatic roof and cathedral-like windows. Purchased in 2019, the home now features two bedrooms (originally three), three bathrooms, two kitchens, a yard, garden, and covered parking. Highlights include expansive decks with Hollywood Sign views, a library-office, steam room, updated kitchen, and a den with a writer's nook, all restored to Atomic Age style.",
                            Details = "Property features 3 bedrooms and 3 full bathrooms, with a den, library, and office as additional rooms. It includes hardwood and carpet flooring, a gas fireplace, and appliances such as a range/oven and refrigerator, with central heating and air conditioning. The total livable interior area is 2,380 sqft.",
                            Advert = "Experience timeless elegance in this Harry Gesner-designed Norwegian Boathouse, a mid-century masterpiece perched above Mulholland Drive with breathtaking views of the Hollywood Sign and Santa Monica Mountains.",
                            Quote = "Futuristic design meets serene artistry",
                            Country = "USA",
                            State = "California",
                            City = "Los Angeles",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/bec53721192e8e24c44614880c6ba4e5-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/ed0563835feb1fefa28e7d7f54c7e3cc-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/b0b03754797fac7ba07f358e4dcdd54e-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/b74d995df49664e9c7888f126227df52-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/7ee958b35d67fed3b52efb2ddae3ab3d-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/a349f90405a0ee83a9da899332e27ba0-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/3dfda2ef4952d30edcdc94c5b63bf2dc-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/4dcce3e21d17facf8c05bf355855e5b5-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/ae170de3be7b055887c995178a7cc1f3-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 15000,
                                LegalFees = 3500,
                                HomeInspection = 450,
                                PropertyInsurance = 7992,
                                MortgageFees = 2500,
                                PropertyTaxes = 23177,
                                HomeownersAssociationFee = null,
                                ListingPrice = 1998000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "Three-story home with expansive space across multiple levels." },
                                new FeaturesAndAmenities{ Text = "No pool features for a simpler outdoor experience." },
                                new FeaturesAndAmenities{ Text = "No spa features, focusing on a minimalist design." },
                                new FeaturesAndAmenities{ Text = "Stunning views of surrounding landmarks and mountains." },
                                new FeaturesAndAmenities{ Text = "Enjoy breathtaking mountain and landmark views from the property." }
                            }
                        },

                        //Beverly Hills
                        new House
                        {
                            Name = "Villa Serenità",
                            Bedrooms = 7,
                            Bathroom = 8,
                            Area = 6854,
                            Description = "Mediterranean Villa on prime 700 Block. 16,300sqft+ lot with spacious yard, pool, grassy area and guest house. Excellent floor plan with high ceilings, 2-story entry hall with sweeping staircase. Paneled living room with fireplace and incredible bookcases for display. Large formal dining room perfect for entertaining. Gourmet kitchen opens via steel case windows to the rear gardens. Upstairs, 5 bedrooms with an exceptional primary suite. Staff suite on main floor, attached 2-car garage. Extraordinary offering in the Flats of Beverly Hills. Walkable to all the finest restaurants and shopping.",
                            Details = "This stunning 6,854 sqft home boasts 7 bedrooms and 8 bathrooms, including 3 full, 4 three-quarter, and 1 half-bath, complemented by spacious rooms such as a library, wine cellar, and master suite with a walk-in closet. Luxurious features include central heating and cooling, hardwood flooring, built-in appliances, and 3 fireplaces located in the living room, family room, and master bedroom.",
                            Advert = "Luxurious Mediterranean villa in prime Beverly Hills, featuring a spacious 16,300+ sqft lot with a pool, guest house, and elegant living spaces perfect for entertaining.",
                            Quote = "Elegant Beverly Hills Mediterranean Retreat",
                            Country = "USA",
                            State = "California",
                            City = "Beverly Hills",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6481a244712f1ba4c6f8f2ebc1b1bc94-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/802807cc01e6f216475c94af0704418f-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/72d8c5a8f50fe446606242c905fc789f-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/ecdadaaef259469fe84b06d33137ea6c-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/043c73c1bf7eae924395d745cc1dd44b-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/44c81867a424a35aa30cfeab3b5fe15f-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/2373564ea20681ec2f0c1edfa1414755-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/7a947f709639d34552cc61f9dd27e9f8-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/a1400985b5637400f2b09b40b5784397-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 740000,
                                LegalFees = 50000,
                                HomeInspection = 20000,
                                PropertyInsurance = 53280,
                                MortgageFees = 45000,
                                PropertyTaxes = 171680,
                                HomeownersAssociationFee = null,
                                ListingPrice = 14800000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities { Text = "Two levels for spacious living." },
                                new FeaturesAndAmenities { Text = "Two-story design with functional layout." },
                                new FeaturesAndAmenities { Text = "In-ground pool for relaxation and fun." },
                                new FeaturesAndAmenities { Text = "In-ground spa for ultimate comfort." },
                                new FeaturesAndAmenities { Text = "Enjoy captivating views from the property." },
                                new FeaturesAndAmenities { Text = "View description not provided." },
                            }
                        },

                        //San Francisco
                        new House
                        {
                            Name = "The Buchanan Bayview Estate",
                            Bedrooms = 6,
                            Bathroom = 8,
                            Area = 8350,
                            Description = "Located in Pacific Heights, 2620 Buchanan is a masterpiece of design and function, just steps from Fillmore and Union Streets. A 4-year renovation offers Bay views on three levels, 13-ft ceilings, and custom finishes. Highlights include a turret-lit living room, chef’s kitchen with dual appliances, and a family room opening to a walk-out deck. The primary suite spans the top level with a dressing room, walk-in closets, and a spa-like wet room. Other features: office with kitchenette, gym, wine storage for 330 bottles, theater room, covered patio with BBQ, 4-car garage with turntable, and high-speed elevator. A rare gem in San Francisco's finest neighborhood.",
                            Details = "This stunning 6 spacious bedrooms, including a luxurious primary suite with a sitting room and walk-in closet, and 8 bathrooms, with 7 full baths and a half bath, thoughtfully designed with premium fixtures like double vanities, soaking tubs, and radiant heating. The expansive 8,350 sqft interior showcases a gourmet kitchen with stone counters, a butler's pantry, and an island, complemented by formal dining and family rooms, a wet bar, cathedral ceilings, and a cozy fireplace with a gas starter in the living room.",
                            Advert = "Experience luxury living at 2620 Buchanan, a masterpiece in Pacific Heights featuring Bay views, a chef's kitchen, a private gym, and a high-speed elevator across three levels of custom design.",
                            Quote = "Luxury redefined in Pacific Heights",
                            Country = "USA",
                            State = "California",
                            City = "San Francisco",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/06d0956d4acb08c3289800d937e026bc-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/be5925225084bf6bb5b5dc1949900ace-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/b79f8b205c6ec33f5a96f7ec0c4add18-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/d9143a76277de4396d79d8066fab9f70-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/afd2a9bae90cae8fc3d184f4847a2ba1-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/236deda0a9aac9c050f05ce6f036e48a-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/efc06b8085f2ea05e19170f8d163ad03-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/52f372540999c9a73b61eb15f99a0da3-uncropped_scaled_within_1536_1152.webp" },
                                new HouseImg { Url = "https://photos.zillowstatic.com/fp/01ab35ae3b487f1d95548fee77ba5440-uncropped_scaled_within_1536_1152.webp" }
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 25000,
                                LegalFees = 3500,
                                HomeInspection = 450,
                                PropertyInsurance = 49500,
                                MortgageFees = 1200,
                                PropertyTaxes = 162250,
                                HomeownersAssociationFee = null,
                                ListingPrice = 13750000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "Private patio for outdoor relaxation" },
                                new FeaturesAndAmenities{ Text = "Balcony with scenic views" },
                                new FeaturesAndAmenities{ Text = "Built-in barbecue for outdoor cooking" },
                                new FeaturesAndAmenities{ Text = "Cozy fire pit for evening gatherings" },
                                new FeaturesAndAmenities{ Text = "Panoramic bay and city views" },
                                new FeaturesAndAmenities{ Text = "Waterfront views of the bay" }
                            }
                        },
                        new House
                        {
                            Name = "The Marina Vista Residence",
                            Bedrooms = 3,
                            Bathroom = 3,
                            Area = 2665,
                            Description = "This remodeled 1925 Marina-style home offers stunning views of the Marina Green and San Francisco Bay. With 3 beds, 3 baths, and 2,665 sq. ft. across two levels, it features a spacious living room, formal dining room, and a chef's kitchen with Viking appliances and quartz countertops. The main level includes a large primary suite with a marble bath, plus two bedrooms and another remodeled bath. The garden level offers a family room, home office, and spa-like bathroom. Additional features include a landscaped garden, parking, and storage. Ideal location near Marina Green, Crissy Field, and more.",
                            Details = "The home features 3 bedrooms and 3 full bathrooms, including a primary bedroom with a closet and sitting area. The spacious interior, spanning 2,665 sqft, includes a formal dining room, family room, kitchen with quartz counters, living room with a view, and a wood-burning fireplace.",
                            Advert = "This extensively remodeled 1925 Marina-style home boasts breathtaking views of the Marina Green and San Francisco Bay, featuring 3 beds, 3 baths, and 2,665 sq. ft. of luxurious living space. Located across from the Marina Green, it includes a gourmet chef's kitchen, large family room suite, spa-like bath, and private landscaped garden, with potential for fast-track condominium conversion.",
                            Quote = "Stately home with sweeping views",
                            Country = "USA",
                            State = "California",
                            City = "San Francisco",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/047b9ace4e541d3176fa5adf787d3f9f-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6a9a1565b26796092c4fe29043619226-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/ab58e9d150a3a541401690d5ce3d6c9f-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/b87a3a8a2fe582f752590ec522b5a948-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/8c6fc0bdb55637a1d2d1f0f6ee7f9dd2-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/5b6991d36f0a73dc4a4db7b4154a4cd5-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/11e54d588119c6e3c1d6c8b7a653a932-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/4f375a8f434d16fe6d06e4380ae2f634-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 54000,
                                LegalFees = 3500,
                                HomeInspection = 500,
                                PropertyInsurance = 9708,
                                MortgageFees = 1500,
                                PropertyTaxes = 31801,
                                HomeownersAssociationFee = null,
                                ListingPrice = 2695000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "Two-story home with ample living space." },
                                new FeaturesAndAmenities{ Text = "Uncovered patio for outdoor enjoyment." },
                                new FeaturesAndAmenities{ Text = "Fenced backyard offering privacy." },
                                new FeaturesAndAmenities{ Text = "Stunning views of the surroundings." },
                                new FeaturesAndAmenities{ Text = "Views of the bay, garden, hills, marina, and water." },
                                new FeaturesAndAmenities{ Text = "Waterfront views of the bay and water." },
                            }
                        },
                        new House
                        {
                            Name = "Prime Noe Valley",
                            Bedrooms = 5,
                            Bathroom = 8,
                            Area = 5200,
                            Description = "Prime Noe Valley fully entitled development opportunity.  This expansive 4 level 5200+/- sq ft residence is ideally located on one of Noe Valley's most coveted flat blocks and sits on an oversized lot. Perfect for strolling to 24th Street shops, restaurants and amenities. The flexible floor plan features 5/6 bedrooms, 6.5 baths, multiple outdoor spaces, amazing sense of scale and amazing natural light. A unique opportunity to build a spacious home that likely could not be entitled under current planning rule limitations. The Site permit is fully approved. Renders are graphic artists' impressions and may not be accurate. Buyer to satisfy themselves in regards to plans/renders and building permit status. This is a 2 unit building, plans call for a 1 level unit and larger 3 level unit above.",
                            Details = "Features five bedrooms and eight bathrooms, including six full bathrooms and two half bathrooms. The total structure area and livable interior area are both 5,200 square feet.",
                            Advert = "Discover a rare opportunity in Prime Noe Valley to build your dream home on an oversized lot, with fully approved plans for a 4-level, 5/6-bedroom residence featuring expansive outdoor spaces and abundant natural light. Located on a coveted flat block, this flexible floor plan offers the perfect balance of privacy and proximity to Noe Valley’s vibrant 24th Street shops and amenities.",
                            Quote = "Prime Noe Valley Dream Home",
                            Country = "USA",
                            State = "California",
                            City = "San Francisco",
                            HouseType = SingleFamily,
                            HouseImgs = new List<HouseImg>{
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/758ec91e4b0e9422b6cc37c8f47512fd-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/1069470b55ab743a55c08249655a937f-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/6fea5f15b424ee5fa48cfd97e594b07a-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/c1bcbc2fa502f5d5346febf0b3b24701-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/4661ba234b18b71ac0a59c284e00c692-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/0de387412889d0968709ba441faffa89-uncropped_scaled_within_1536_1152.webp"},
                                new HouseImg { Url =  "https://photos.zillowstatic.com/fp/65634987a9f052616f4386ab10a29e80-uncropped_scaled_within_1536_1152.webp"},
                            },
                            Pricing = new Pricing
                            {
                                PropertyTransferTax = 50000,
                                LegalFees = 1500,
                                HomeInspection = 300,
                                PropertyInsurance = 10068,
                                MortgageFees = 1500,
                                PropertyTaxes = 32981,
                                HomeownersAssociationFee = null,
                                ListingPrice = 2795000,
                            },
                            FeaturesAndAmenities = new List<FeaturesAndAmenities>
                            {
                                new FeaturesAndAmenities{ Text = "Cozy carpet, durable tile, and elegant wood flooring options."},
                                new FeaturesAndAmenities{ Text = "One inviting fireplace for warmth and ambiance."},
                                new FeaturesAndAmenities{ Text = "Traditional wood-burning fireplace for a rustic feel."},
                            } 
                        },
                    };

                    await context.AddRangeAsync(houses);
                }

                if (!context.Reviews.Any())
                {
                    var reviews = new List<Review>
                    {
                        new Review
                        {
                            Heading = "Outstanding Service!",
                            Comment = "The team was incredibly helpful and professional. They found the perfect home for us in a great neighborhood. Highly recommend!",
                            Rate = 5,
                            Client = new Client
                            {
                                FullName = "Sarah Johnson",
                                Country = "USA",
                                State = "California",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen8951a5d59d7b62c054af7ead6c0f247a.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Very Satisfied with My New Home",
                            Comment = "This agency made the whole process so easy. I was nervous at first, but they guided me step by step. I love my new place!",
                            Rate = 4,
                            Client = new Client
                            {
                                FullName = "John Smith",
                                Country = "Canada",
                                State = "Ontario",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen9cb20908b5bcb4896d58de37baf1c40f.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Quick and Efficient!",
                            Comment = "The team was efficient and professional. They understood my requirements and showed me homes within my budget.",
                            Rate = 5,
                            Client = new Client
                            {
                                FullName = "Emma Davis",
                                Country = "USA",
                                State = "Texas",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen49e6261bcf8e965bd9f00fde8a6c4561.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Amazing Experience",
                            Comment = "Great customer service and excellent selection of properties. I found my dream home thanks to them!",
                            Rate = 5,
                            Client = new Client
                            {
                                FullName = "Michael Brown",
                                Country = "USA",
                                State = "Florida",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen7f151f64949cbb00a009a4e2d165972b.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Great Experience, Highly Recommended!",
                            Comment = "The agents were very responsive and professional throughout the entire process. Will definitely recommend to friends.",
                            Rate = 5,
                            Client = new Client
                            {
                                FullName = "Olivia Wilson",
                                Country = "UK",
                                State = "London",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen54c77cbca79528a46d00ebe9b0f4b750.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Not What I Expected",
                            Comment = "While the team was friendly, the property options were not exactly what I was hoping for. Still, they did their best to help me find something.",
                            Rate = 3,
                            Client = new Client
                            {
                                FullName = "David Lee",
                                Country = "Australia",
                                State = "Sydney",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen234a907aa0583a3e7b2b0d7f095448f9.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Very Helpful Throughout the Process",
                            Comment = "From the first meeting to the final closing, they were helpful and attentive to all of my questions. A smooth transaction overall.",
                            Rate = 4,
                            Client = new Client
                            {
                                FullName = "Lucas Harris",
                                Country = "USA",
                                State = "New York",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen840212179ed94ab7d009f6e6b9770fa7.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "A Wonderful Buying Experience",
                            Comment = "I had a great time buying my first home. The team provided excellent advice and support. I will definitely reach out again in the future.",
                            Rate = 5,
                            Client = new Client
                            {
                                FullName = "Sophia Martinez",
                                Country = "Mexico",
                                State = "Jalisco",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen27d954a72f56fa673a3defab6c5128bb.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Great Service, but Some Delays",
                            Comment = "The team was very professional, but there were a few delays in getting the paperwork sorted out. Still, everything worked out in the end.",
                            Rate = 4,
                            Client = new Client
                            {
                                FullName = "James Garcia",
                                Country = "USA",
                                State = "Nevada",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen3480d8fa71f65d2a2bad35721ff501ce.jpg"
                            }
                        },
                        new Review
                        {
                            Heading = "Excellent Help with Finding a Rental",
                            Comment = "I was looking for a rental, and they were quick to find me a great place. The team was friendly and efficient. Thanks for your help!",
                            Rate = 5,
                            Client = new Client
                            {
                                FullName = "Isabella Anderson",
                                Country = "Canada",
                                State = "Vancouver",
                                ImgUrl = "https://this-person-does-not-exist.com/img/avatar-gen1bd563fe9c7f39be633c4cf9a87ec451.jpg"
                            }
                        }
                    };

                    await context.AddRangeAsync(reviews);
                }

                if (!context.ValuedClients.Any())
                {

                    var commercial = new Category { Type = "Commercial" };
                    var residential = new Category { Type = "Residential" };
                    var industrial = new Category { Type = "Industrial" };

                    var valuedClients = new List<ValuedClient>
                    {
                        new ValuedClient
                        {
                            Company = "ABC Corp",
                            Domain = "Construction",
                            Year = "2020",
                            Category = commercial,
                            Comment = "Working with this team has been a seamless experience. Their professionalism and timely delivery are unmatched!"
                        },
                        new ValuedClient
                        {
                            Company = "XYZ Ltd",
                            Domain = "Real Estate",
                            Year = "2021",
                            Category = residential,
                            Comment = "Their attention to detail and dedication to meeting our needs has been truly commendable. Highly recommended!"
                        },
                        new ValuedClient
                        {
                            Company = "Omega Group",
                            Domain = "Hospitality",
                            Year = "2019",
                            Category = commercial,
                            Comment = "Exceptional service and innovative solutions. They've consistently exceeded our expectations!"
                        },
                        new ValuedClient
                        {
                            Company = "Delta Ventures",
                            Domain = "Retail",
                            Year = "2022",
                            Category = industrial,
                            Comment = "A trustworthy partner who understands the industry inside out. Their expertise has been invaluable to our projects."
                        },
                        new ValuedClient
                        {
                            Company = "Prime Estates",
                            Domain = "Property Development",
                            Year = "2020",
                            Category = residential,
                            Comment = "From start to finish, the team ensured a smooth process. Their dedication to quality is evident in every aspect."
                        },
                    };


                    await context.AddRangeAsync(valuedClients);
                }

                context.SaveChanges();
            }
        }
    }
}
