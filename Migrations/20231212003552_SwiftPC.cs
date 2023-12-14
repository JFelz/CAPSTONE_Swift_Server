using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CAPSTONE_Swift_Server.Migrations
{
    /// <inheritdoc />
    public partial class SwiftPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "carts",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "bio",
                table: "users");

            migrationBuilder.DropColumn(
                name: "image_url",
                table: "users");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_time",
                value: new DateTime(2023, 12, 11, 18, 35, 52, 714, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "admin_id", "category", "description", "image_url1", "image_url2", "image_url3", "length", "price", "skate_spots", "title", "wheelbase", "width" },
                values: new object[,]
                {
                    { 6, 1, "downhill", "A pillar of the Landyachtz DH line for over a decade, the Evo has been under the feet of 3 World Champions as well as countless race winners and podium contenders. The Evo 40 offers a drifty and stable ride that will fill any day in the hills with casually fast runs.", "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Setup-WEB-Graphic_1800x1800.jpg?v=1628815758", "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Setup-WEB-Grip_1800x1800.jpg?v=1628815758", "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Cover-WEB-Angle-01_1800x1800.jpg?v=1628815758", 39.0, 259.99000000000001, "Hill, Mountain, Race Track", "EVO 40 - SPECTRUM", 31.699999999999999, 9.8000000000000007 },
                    { 7, 1, "downhill", "Will it freeride? Obviously. Will it also grip? Heck yes! Clayton Arthurs is one of the most versatile members of the Landyachtz team and he wanted his pro board to be able to make the switch from race track to slide jam just as comfortably as he can. The Blaze is designed to be equally effective with small slalom trucks on it for tons of grip, or with 155mm symmetrical trucks and freeride wheels for huge standup slides.", "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboardgraphic_AD_4761-WEB_b00e1698-5cc0-4f79-bb20-e97ae05c4d55_1800x1800.jpg?v=1646115057", "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboard4_AD_4787-WEB_3f68fa55-dce3-4f93-a0cc-8d3a50a0f4bd_1800x1800.jpg?v=1646115057", "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboardwheeldown_AD_4769-WEB_8654a3fe-f1ef-4342-b733-4663fe4276e3_1800x1800.jpg?v=1646115057", 34.0, 299.99000000000001, "Pathways,Steep Hills, Big Mountain Road, all terrain", "BLAZE - PT", 23.699999999999999, 9.0 },
                    { 8, 1, "dance", "Designed as an intuitive carving and pumping board, the Dervish Sama longboard is low and easy to ride for both the first-time skater looking to cruise around town and the experienced rider seeking a soulful, snowboard-inspired ride and the ability to explore longboard dancing and freestyle.", "https://i.pinimg.com/originals/36/2b/64/362b64f26bfaa8cdd77b3efacc2545fc.png", "https://i.pinimg.com/originals/25/51/a9/2551a9ef0fc02f9dacd3a5fa4fa5f2b8.png", "https://www.loadedboards.com/cdn/shop/files/Loaded-Dervish-Sama-2023-complete-profile-2048p.jpg?v=1683235420&width=2036", 42.799999999999997, 328.0, "Pathways, Campus, Mellow Hills", "DERVISH SAMA", 31.5, 9.0 },
                    { 9, 1, "dance", "Since 2008 Loaded has been on the forefront of longboard dancing. The Tarab II deepens our roots and seeks to advance modern longboard dancing through thoughtful design and material evolution. Ideal for riders who want a versatile and well-rounded platform for surfy boardwalking lines, smooth freestyle trickery, and everything in between.", "https://i.pinimg.com/originals/06/60/39/0660399607e658a1c527907ba5050811.jpg", "https://i.pinimg.com/originals/08/d2/97/08d2976506d5171067010399673cc000.jpg", "https://thuroshop.com/cdn/shop/products/Loaded-Tarab-II-Complete-profile-2048p_720x_8234d16f-d563-4243-91f1-ac50fdded4e1.jpg?v=1677611277", 47.0, 444.0, "Pathways, Campus, Mellow Hills", "TARAB II", 31.25, 9.5 },
                    { 10, 1, "electric", "Dubbed City Rider 3 for its evolution in skateboarding, this masterpiece speaks to both new riders and seasoned enthusiasts. We understand that whether you're gliding on city asphalt or bustling streets, the allure of off-road skating remains. Safety, the essence of your experience, is ingeniously woven into the City Rider 3’s DNA. With large 150mm wheels and a wide truck long board, you’re equipped to conquer obstacles with confidence, and the enhanced stability makes each ride a testament to your secure journey.", "https://i.pinimg.com/originals/81/0e/cd/810ecd7a3a7f76595090e15539884a30.jpg", "https://i.pinimg.com/originals/f4/10/9f/f4109fc8f6c82c6988378481d43bc535.jpg", "https://i.pinimg.com/originals/ad/47/11/ad4711f25374e57ed42551144305b265.jpg", 42.799999999999997, 899.0, "Hill, Mountain, Race Track, all terrain", "SWIFT CITY RIDER 3", 150.0, 9.0 },
                    { 11, 1, "pintail", "Dropped low, like the Apex 34 and Apex 37, the Pintail 43 is a plate special with all the fixins to satiate your longboard hunger. This tasty delicacy is 43 inches of medium rare satisfaction, served with a slight concave, and the finest graphic art au jus by Joe Hodnicki....", "https://shop.originalskateboards.com/cdn/shop/products/Maple-Pintail-43-complete-2-1_f30099a0-e636-473f-abb0-f13b8ade70f7_460x.jpg?v=1666908787", "https://shop.originalskateboards.com/cdn/shop/products/2016_Pintail_43_01-e1478098471915_50de8da7-9c58-4a2f-8dee-d3853f160a6a_460x.jpg?v=1666908788", "https://shop.originalskateboards.com/cdn/shop/products/2016_Pintail_43_08-e1478098402677_bd220c4c-5164-4f36-b66c-8d4137426c4d_460x.jpg?v=1666908788", 43.0, 239.99000000000001, "Pathways, Campus, Mellow Hills", "PINTAIL 43", 29.5, 9.0 },
                    { 12, 1, "pintail", "Our favorite mini-carver sprouted a kicktail, and things have never been the same. Let the Derringer 33 manual its way, your way, and straight into your heart with 3 killer new graphics. ", "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-Longboardresurface_c7935af0-e160-4bd5-bf67-1aa8714a9f45.jpg?v=1597175756", "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-LongboardV4_f7cc2812-c11f-47cf-894d-92b99ef96c2b.jpg?v=1597175756", "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-LongboardV2_655b4655-7808-421a-8c35-2421796a27e3.jpg?v=1597175756", 33.0, 199.99000000000001, "Pathways, Campus, Mellow Hills", "DERRINGER 33", 29.5, 9.0 },
                    { 13, 1, "freeride", "The Basalt Tesseract integrates dual kicktails, rocker, wheel well flares, W concave, and multiple wheelbase options into a lightweight package designed for hilly descents, snappy slides, lofty ollies, techy manual combos, and cross-steps galore.\r\n\r\nBuilding on our experience manufacturing the Tarab, we’ve updated the Basalt Tesseract with a high-performance, eco-conscious basalt fabric construction for a lighter, damper, and more freestyle-friendly longboard. Get lit with lava.", "https://www.kickpush.com.au/assets/alt_1/786143.jpg?20230816102317", "https://www.kickpush.com.au/assets/full/786143.jpg?20230816102609", "https://m.media-amazon.com/images/I/71FYI3wbXGL.jpg", 39.0, 339.99000000000001, "Pathways, Campus, Mellow Hills, City Streets", "BASALT TESSERACT", 26.0, 9.5 },
                    { 14, 1, "beginner", "The Big Dipper is like a magic carpet with wheels. Coming in at 42.2” long and boasting a healthy amount of flex, this is a longboard in the classic sense of the word. Because of its length, the Big Dipper is very forgiving to ride, whether you are a beginner learning to skate or someone trying to push the limits of what a flexy longboard can do. This beast is the perfect choice for anyone looking for a smooth & stable ride with lots of flow and surf style.", "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardgraphic_AD_4748-WEB_1800x1800.jpg?v=1651272223", "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardgrip_AD_4749-WEB_1800x1800.jpg?v=1651272223", "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardwheeldown_AD_4764-WEB_1800x1800.jpg?v=1651272223", 42.200000000000003, 249.99000000000001, "Pathways, Campus, Mellow Hills, City Streets, Beach", "BIG DIPPER - MOUNTAIN", 29.800000000000001, 9.4800000000000004 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.AddColumn<string>(
                name: "bio",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "carts",
                columns: new[] { "id", "customer_uid" },
                values: new object[] { 1, "p84DEdgj4kYhU4VKJfFqZX7unHD3" });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_time",
                value: new DateTime(2023, 11, 28, 11, 28, 7, 439, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "bio", "image_url" },
                values: new object[] { "I am CEO", "https://media.licdn.com/dms/image/D4E03AQFmqmxDnBFpjw/profile-displayphoto-shrink_800_800/0/1695423491664?e=1706140800&v=beta&t=1YCpHpITTc_ME9YctHk0Vte8hhYzmhieSmxiH258VA4" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "bio", "image_url" },
                values: new object[] { "I am a Customer", "https://img.freepik.com/free-photo/young-bearded-man-with-striped-shirt_273609-5677.jpg?w=2000" });
        }
    }
}
