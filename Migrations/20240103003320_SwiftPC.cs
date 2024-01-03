using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_carts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "newsletter_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_uid = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_newsletter_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_uid = table.Column<string>(type: "text", nullable: false),
                    customer_name = table.Column<string>(type: "text", nullable: false),
                    customer_email = table.Column<string>(type: "text", nullable: false),
                    customer_phone_number = table.Column<long>(type: "bigint", nullable: false),
                    street_address = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    town_city = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(type: "text", nullable: false),
                    zipcode = table.Column<int>(type: "integer", nullable: false),
                    date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    revenue = table.Column<double>(type: "double precision", nullable: false),
                    shipping_method = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<bool>(type: "boolean", nullable: false),
                    payment_type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    admin_id = table.Column<int>(type: "integer", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    category = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<double>(type: "double precision", nullable: false),
                    length = table.Column<double>(type: "double precision", nullable: false),
                    width = table.Column<double>(type: "double precision", nullable: false),
                    wheelbase = table.Column<double>(type: "double precision", nullable: false),
                    skate_spots = table.Column<string>(type: "text", nullable: false),
                    image_url1 = table.Column<string>(type: "text", nullable: false),
                    image_url2 = table.Column<string>(type: "text", nullable: false),
                    image_url3 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_uid = table.Column<string>(type: "text", nullable: false),
                    subject = table.Column<string>(type: "text", nullable: false),
                    content = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reviews", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_uid = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<long>(type: "bigint", nullable: false),
                    is_admin = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cart_product",
                columns: table => new
                {
                    cart_list_id = table.Column<int>(type: "integer", nullable: false),
                    product_list_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cart_product", x => new { x.cart_list_id, x.product_list_id });
                    table.ForeignKey(
                        name: "fk_cart_product_carts_cart_list_id",
                        column: x => x.cart_list_id,
                        principalTable: "carts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cart_product_products_product_list_id",
                        column: x => x.product_list_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_product",
                columns: table => new
                {
                    order_list_id = table.Column<int>(type: "integer", nullable: false),
                    product_list_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_order_product", x => new { x.order_list_id, x.product_list_id });
                    table.ForeignKey(
                        name: "fk_order_product_orders_order_list_id",
                        column: x => x.order_list_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_order_product_products_product_list_id",
                        column: x => x.product_list_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_review",
                columns: table => new
                {
                    products_id = table.Column<int>(type: "integer", nullable: false),
                    review_list_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product_review", x => new { x.products_id, x.review_list_id });
                    table.ForeignKey(
                        name: "fk_product_review_products_products_id",
                        column: x => x.products_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_product_review_reviews_review_list_id",
                        column: x => x.review_list_id,
                        principalTable: "reviews",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "newsletter_users",
                columns: new[] { "id", "customer_uid", "email" },
                values: new object[] { 1, "zcxxFyDPReWizoUPtyPru9w072J3", "feliz.jovanni@gmail.com" });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "id", "country", "customer_email", "customer_name", "customer_phone_number", "customer_uid", "date_time", "payment_type", "revenue", "shipping_method", "state", "status", "street_address", "town_city", "zipcode" },
                values: new object[] { 1, "USA", "MahlJ@gmail.com", "John Mahlar", 4324566788L, "p84DEdgj4kYhU4VKJfFqZX7unHD3", new DateTime(2024, 1, 2, 18, 33, 20, 394, DateTimeKind.Local).AddTicks(9803), "visa", 581.99000000000001, "Standard", "MS", false, "431 Grove Ave", "Salt Lake City", 37205 });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "admin_id", "category", "description", "image_url1", "image_url2", "image_url3", "length", "price", "skate_spots", "title", "wheelbase", "width" },
                values: new object[,]
                {
                    { 1, 1, "cruiser", "A snowboard-inspired drop-through for easy around town cruising, relaxed commutes, and mellow downhill.", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Combined.jpg?v=1697137406&width=1100", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Top.jpg?v=1697137406&width=1100", "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg", 37.0, 119.98999999999999, "Pathways, Campus, Mellow Hills", "AXIS 37", 119.98999999999999, 8.5 },
                    { 2, 1, "carving", "A single-kick carver designed to be agile for all of your out-and-about missions.", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Bottom.jpg?v=1697137562&width=1445", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Top.jpg?v=1697137562&width=1445", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Three-Quarter.jpg?v=1697137562&width=1445", 35.0, 89.989999999999995, "Pathways, Campus, Mellow Hills", "ARBOR - MISSION", 21.375, 8.625 },
                    { 3, 1, "cruiser", "The Dipper is a pintail designed to bring the compact maneuverability of a cruiser board to a carvy, flexy longboard shape. This board gives you a tight-turning, responsive ride that will make weekday commutes or casual weekend cruises the highlight of your week. The narrow width provides you with incredible control over the edges of the board so you can ride this thing aggressively if you want to or take it easy on those casual cruises. Mellow concave and a subtle rocker will have you feeling right at home on this board. Often referred to as the “best board ever” at skate sessions.", "https://media.rainpos.com/3226/Screenshot_2023_05_31_at_16_49_06_Dipper_Fish.png", "https://www.directiveboardshop.com/cdn/shop/files/weeee.png?v=1683766868&width=1946", "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg", 36.0, 169.99000000000001, "Pathways, Campus, Mellow Hills", "DIPPER - FISH", 24.289999999999999, 8.6500000000000004 },
                    { 4, 1, "carving", "Designed to rally big mountain terrain and conquer World Cup podiums, the Switchblade has proven itself equally adept at getting you to the grocery store and ripping down your local hill safely. The mellow drops, long wheelbase and low ride height combine to offer a drifty, confidence-inspiring feel perfect for riders looking to up their freeride game. The Switchblade 40 is the longer version, offering a more stable ride and slightly easier slide initiation, as well as being a bit more comfortable for taller riders.", "https://landyachtz.com/cdn/shop/files/landyachtz-switchblade-night-40--Graphic-WEB_1200x1200.jpg?v=1683932973", "https://www.sourceboards.com/cdn/shop/products/Landyachtz-2022-Switchblade-40-Chief-Night-Complete_1_1200x1200.jpg?v=1653941378", "https://skate-works-shop.myshopify.com/cdn/shop/products/121CP-DHSB40CHFN-Switchblade40ChiefNightCompleteelasco69swheelup_AD_9975-WEB_1800x1800_0795102e-eefc-4d9e-aaad-ea8623317694_1024x1024@2x.webp?v=1669835848", 40.0, 169.99000000000001, "City, Alley, Path, Campus, Hill, Mountain", "SWITCHBLADE 40 - CHIEF NIGHTK", 31.0, 10.0 },
                    { 5, 1, "cruiser", "Time-tested maple construction and super low ride height come together with a futuristic rocker profile to create a board that lets you travel through time to sample the very best of what we've learned over 20-plus years of designing boards. The Drop Cat 38 is perfect for taller riders or people looking for a more stable ride.", "https://landyachtz.com/cdn/shop/products/Drop-Cat-38-Black-Seeker-Graphic-WEB_b7086e12-107a-4631-8b8e-f0658f0a4088_1800x1800.jpg?v=1614532582", "https://m.media-amazon.com/images/I/41aHxpyyznL._AC_UF1000,1000_QL80_.jpg", "https://m.media-amazon.com/images/I/41IIyAwWnjL._AC_UF1000,1000_QL80_.jpg", 38.600000000000001, 212.49000000000001, "Pathways, Campus, Mellow Hills", "DROP CAT 38 - SEEKER BLACK", 29.300000000000001, 9.9000000000000004 },
                    { 6, 1, "downhill", "A pillar of the Landyachtz DH line for over a decade, the Evo has been under the feet of 3 World Champions as well as countless race winners and podium contenders. The Evo 40 offers a drifty and stable ride that will fill any day in the hills with casually fast runs.", "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Setup-WEB-Graphic_1800x1800.jpg?v=1628815758", "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Setup-WEB-Grip_1800x1800.jpg?v=1628815758", "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Cover-WEB-Angle-01_1800x1800.jpg?v=1628815758", 39.0, 259.99000000000001, "Hill, Mountain, Race Track", "EVO 40 - SPECTRUM", 31.699999999999999, 9.8000000000000007 },
                    { 7, 1, "downhill", "Will it freeride? Obviously. Will it also grip? Heck yes! Clayton Arthurs is one of the most versatile members of the Landyachtz team and he wanted his pro board to be able to make the switch from race track to slide jam just as comfortably as he can. The Blaze is designed to be equally effective with small slalom trucks on it for tons of grip, or with 155mm symmetrical trucks and freeride wheels for huge standup slides.", "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboardgraphic_AD_4761-WEB_b00e1698-5cc0-4f79-bb20-e97ae05c4d55_1800x1800.jpg?v=1646115057", "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboard4_AD_4787-WEB_3f68fa55-dce3-4f93-a0cc-8d3a50a0f4bd_1800x1800.jpg?v=1646115057", "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboardwheeldown_AD_4769-WEB_8654a3fe-f1ef-4342-b733-4663fe4276e3_1800x1800.jpg?v=1646115057", 34.0, 299.99000000000001, "Pathways,Steep Hills, Big Mountain Road, all terrain", "BLAZE - PT", 23.699999999999999, 9.0 },
                    { 8, 1, "dance", "Designed as an intuitive carving and pumping board, the Dervish Sama longboard is low and easy to ride for both the first-time skater looking to cruise around town and the experienced rider seeking a soulful, snowboard-inspired ride and the ability to explore longboard dancing and freestyle.", "https://i.pinimg.com/originals/36/2b/64/362b64f26bfaa8cdd77b3efacc2545fc.png", "https://i.pinimg.com/originals/25/51/a9/2551a9ef0fc02f9dacd3a5fa4fa5f2b8.png", "https://www.loadedboards.com/cdn/shop/files/Loaded-Dervish-Sama-2023-complete-profile-2048p.jpg?v=1683235420&width=2036", 42.799999999999997, 329.99000000000001, "Pathways, Campus, Mellow Hills", "DERVISH SAMA", 31.5, 9.0 },
                    { 9, 1, "dance", "Since 2008 Loaded has been on the forefront of longboard dancing. The Tarab II deepens our roots and seeks to advance modern longboard dancing through thoughtful design and material evolution. Ideal for riders who want a versatile and well-rounded platform for surfy boardwalking lines, smooth freestyle trickery, and everything in between.", "https://i.pinimg.com/originals/06/60/39/0660399607e658a1c527907ba5050811.jpg", "https://i.pinimg.com/originals/08/d2/97/08d2976506d5171067010399673cc000.jpg", "https://thuroshop.com/cdn/shop/products/Loaded-Tarab-II-Complete-profile-2048p_720x_8234d16f-d563-4243-91f1-ac50fdded4e1.jpg?v=1677611277", 47.0, 444.99000000000001, "Pathways, Campus, Mellow Hills", "TARAB II", 31.25, 9.5 },
                    { 10, 1, "electric", "Dubbed City Rider 3 for its evolution in skateboarding, this masterpiece speaks to both new riders and seasoned enthusiasts. We understand that whether you're gliding on city asphalt or bustling streets, the allure of off-road skating remains. Safety, the essence of your experience, is ingeniously woven into the City Rider 3’s DNA. With large 150mm wheels and a wide truck long board, you’re equipped to conquer obstacles with confidence, and the enhanced stability makes each ride a testament to your secure journey.", "https://i.pinimg.com/originals/81/0e/cd/810ecd7a3a7f76595090e15539884a30.jpg", "https://i.pinimg.com/originals/f4/10/9f/f4109fc8f6c82c6988378481d43bc535.jpg", "https://i.pinimg.com/originals/ad/47/11/ad4711f25374e57ed42551144305b265.jpg", 42.799999999999997, 899.99000000000001, "Hill, Mountain, Race Track, all terrain", "SWIFT CITY RIDER 3", 150.0, 9.0 },
                    { 11, 1, "pintail", "Dropped low, like the Apex 34 and Apex 37, the Pintail 43 is a plate special with all the fixins to satiate your longboard hunger. This tasty delicacy is 43 inches of medium rare satisfaction, served with a slight concave, and the finest graphic art au jus by Joe Hodnicki....", "https://shop.originalskateboards.com/cdn/shop/products/Maple-Pintail-43-complete-2-1_f30099a0-e636-473f-abb0-f13b8ade70f7_460x.jpg?v=1666908787", "https://shop.originalskateboards.com/cdn/shop/products/2016_Pintail_43_01-e1478098471915_50de8da7-9c58-4a2f-8dee-d3853f160a6a_460x.jpg?v=1666908788", "https://shop.originalskateboards.com/cdn/shop/products/2016_Pintail_43_08-e1478098402677_bd220c4c-5164-4f36-b66c-8d4137426c4d_460x.jpg?v=1666908788", 43.0, 239.99000000000001, "Pathways, Campus, Mellow Hills", "PINTAIL 43", 29.5, 9.0 },
                    { 12, 1, "pintail", "Our favorite mini-carver sprouted a kicktail, and things have never been the same. Let the Derringer 33 manual its way, your way, and straight into your heart with 3 killer new graphics. ", "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-Longboardresurface_c7935af0-e160-4bd5-bf67-1aa8714a9f45.jpg?v=1597175756", "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-LongboardV4_f7cc2812-c11f-47cf-894d-92b99ef96c2b.jpg?v=1597175756", "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-LongboardV2_655b4655-7808-421a-8c35-2421796a27e3.jpg?v=1597175756", 33.0, 199.99000000000001, "Pathways, Campus, Mellow Hills", "DERRINGER 33", 29.5, 9.0 },
                    { 13, 1, "freeride", "The Basalt Tesseract integrates dual kicktails, rocker, wheel well flares, W concave, and multiple wheelbase options into a lightweight package designed for hilly descents, snappy slides, lofty ollies, techy manual combos, and cross-steps galore.\r\n\r\nBuilding on our experience manufacturing the Tarab, we’ve updated the Basalt Tesseract with a high-performance, eco-conscious basalt fabric construction for a lighter, damper, and more freestyle-friendly longboard. Get lit with lava.", "https://www.kickpush.com.au/assets/alt_1/786143.jpg?20230816102317", "https://www.kickpush.com.au/assets/full/786143.jpg?20230816102609", "https://m.media-amazon.com/images/I/71FYI3wbXGL.jpg", 39.0, 339.99000000000001, "Pathways, Campus, Mellow Hills, City Streets", "BASALT TESSERACT", 26.0, 9.5 },
                    { 14, 1, "beginner", "The Big Dipper is like a magic carpet with wheels. Coming in at 42.2” long and boasting a healthy amount of flex, this is a longboard in the classic sense of the word. Because of its length, the Big Dipper is very forgiving to ride, whether you are a beginner learning to skate or someone trying to push the limits of what a flexy longboard can do. This beast is the perfect choice for anyone looking for a smooth & stable ride with lots of flow and surf style.", "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardgraphic_AD_4748-WEB_1800x1800.jpg?v=1651272223", "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardgrip_AD_4749-WEB_1800x1800.jpg?v=1651272223", "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardwheeldown_AD_4764-WEB_1800x1800.jpg?v=1651272223", 42.200000000000003, 249.99000000000001, "Pathways, Campus, Mellow Hills, City Streets, Beach", "BIG DIPPER - MOUNTAIN", 29.800000000000001, 9.4800000000000004 }
                });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "id", "content", "customer_uid", "rating", "subject" },
                values: new object[,]
                {
                    { 1, "I love this product!", "p84DEdgj4kYhU4VKJfFqZX7unHD3", 5, "I approve!" },
                    { 2, "The board was flimsy. Bad product.", "p84DEdgj4kYhU4VKJfFqZX7unHD3", 1, "Don't recommend! Bad Product." },
                    { 3, "I bought one for my cousin and he loved it!!", "p84DEdgj4kYhU4VKJfFqZX7unHD3", 4, "Great purchase! Happy Customer" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "customer_uid", "email", "is_admin", "name", "phone_number" },
                values: new object[,]
                {
                    { 1, "zcxxFyDPReWizoUPtyPru9w072J3", "feliz.jovanni@gmail.com", true, "Jovanni Feliz", 6037779999L },
                    { 2, "p84DEdgj4kYhU4VKJfFqZX7unHD3", "MahlJ@gmail.com", false, "John Mahlar", 4324566788L }
                });

            migrationBuilder.CreateIndex(
                name: "ix_cart_product_product_list_id",
                table: "cart_product",
                column: "product_list_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_product_product_list_id",
                table: "order_product",
                column: "product_list_id");

            migrationBuilder.CreateIndex(
                name: "ix_product_review_review_list_id",
                table: "product_review",
                column: "review_list_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart_product");

            migrationBuilder.DropTable(
                name: "newsletter_users");

            migrationBuilder.DropTable(
                name: "order_product");

            migrationBuilder.DropTable(
                name: "product_review");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "reviews");
        }
    }
}
