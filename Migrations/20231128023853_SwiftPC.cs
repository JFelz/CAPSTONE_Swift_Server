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
            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "customer_uid",
                table: "reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "customer_uid",
                table: "orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "payment_type_id",
                table: "orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "order_statuses",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "carts",
                columns: new[] { "id", "customer_uid" },
                values: new object[] { 1, "p84DEdgj4kYhU4VKJfFqZX7unHD3" });

            migrationBuilder.InsertData(
                table: "order_statuses",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "active" },
                    { 2, "closed" },
                    { 3, "pending" }
                });

            migrationBuilder.InsertData(
                table: "payment_types",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "visa" },
                    { 2, "mastercard" },
                    { 3, "amex" },
                    { 4, "apple pay" },
                    { 5, "venmo" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "admin_id", "category", "description", "image_url1", "image_url2", "image_url3", "length", "price", "skate_spots", "title", "wheelbase", "width" },
                values: new object[,]
                {
                    { 1, 1, "cruiser", "A snowboard-inspired drop-through for easy around town cruising, relaxed commutes, and mellow downhill.", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Combined.jpg?v=1697137406&width=1100", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Top.jpg?v=1697137406&width=1100", "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg", 37.0, 119.98999999999999, "Pathways, Campus, Mellow Hills", "AXIS 37", 119.98999999999999, 8.5 },
                    { 2, 1, "carving", "A single-kick carver designed to be agile for all of your out-and-about missions.", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Bottom.jpg?v=1697137562&width=1445", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Top.jpg?v=1697137562&width=1445", "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Three-Quarter.jpg?v=1697137562&width=1445", 35.0, 89.989999999999995, "Pathways, Campus, Mellow Hills", "ARBOR - MISSION", 21.375, 8.625 },
                    { 3, 1, "cruiser", "The Dipper is a pintail designed to bring the compact maneuverability of a cruiser board to a carvy, flexy longboard shape. This board gives you a tight-turning, responsive ride that will make weekday commutes or casual weekend cruises the highlight of your week. The narrow width provides you with incredible control over the edges of the board so you can ride this thing aggressively if you want to or take it easy on those casual cruises. Mellow concave and a subtle rocker will have you feeling right at home on this board. Often referred to as the “best board ever” at skate sessions.", "https://media.rainpos.com/3226/Screenshot_2023_05_31_at_16_49_06_Dipper_Fish.png", "https://www.directiveboardshop.com/cdn/shop/files/weeee.png?v=1683766868&width=1946", "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg", 36.0, 169.99000000000001, "Pathways, Campus, Mellow Hills", "DIPPER - FISH", 24.289999999999999, 8.6500000000000004 },
                    { 4, 1, "carving", "Designed to rally big mountain terrain and conquer World Cup podiums, the Switchblade has proven itself equally adept at getting you to the grocery store and ripping down your local hill safely. The mellow drops, long wheelbase and low ride height combine to offer a drifty, confidence-inspiring feel perfect for riders looking to up their freeride game. The Switchblade 40 is the longer version, offering a more stable ride and slightly easier slide initiation, as well as being a bit more comfortable for taller riders.", "https://landyachtz.com/cdn/shop/files/landyachtz-switchblade-night-40--Graphic-WEB_1200x1200.jpg?v=1683932973", "https://www.sourceboards.com/cdn/shop/products/Landyachtz-2022-Switchblade-40-Chief-Night-Complete_1_1200x1200.jpg?v=1653941378", "https://skate-works-shop.myshopify.com/cdn/shop/products/121CP-DHSB40CHFN-Switchblade40ChiefNightCompleteelasco69swheelup_AD_9975-WEB_1800x1800_0795102e-eefc-4d9e-aaad-ea8623317694_1024x1024@2x.webp?v=1669835848", 40.0, 169.99000000000001, "City, Alley, Path, Campus, Hill, Mountain", "SWITCHBLADE 40 - CHIEF NIGHTK", 31.0, 10.0 },
                    { 5, 1, "cruiser", "Time-tested maple construction and super low ride height come together with a futuristic rocker profile to create a board that lets you travel through time to sample the very best of what we've learned over 20-plus years of designing boards. The Drop Cat 38 is perfect for taller riders or people looking for a more stable ride.", "https://landyachtz.com/cdn/shop/products/Drop-Cat-38-Black-Seeker-Graphic-WEB_b7086e12-107a-4631-8b8e-f0658f0a4088_1800x1800.jpg?v=1614532582", "https://m.media-amazon.com/images/I/41aHxpyyznL._AC_UF1000,1000_QL80_.jpg", "https://m.media-amazon.com/images/I/41IIyAwWnjL._AC_UF1000,1000_QL80_.jpg", 38.600000000000001, 212.49000000000001, "Pathways, Campus, Mellow Hills", "DROP CAT 38 - SEEKER BLACK", 29.300000000000001, 9.9000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "id", "content", "customer_uid" },
                values: new object[,]
                {
                    { 1, "I love this product!", "p84DEdgj4kYhU4VKJfFqZX7unHD3" },
                    { 2, "The board was flimsy. Bad product.", "p84DEdgj4kYhU4VKJfFqZX7unHD3" },
                    { 3, "I bought one for my cousin and he loved it!!", "p84DEdgj4kYhU4VKJfFqZX7unHD3" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "bio", "email", "image_url", "is_admin", "name", "phone_number", "uid" },
                values: new object[,]
                {
                    { 1, "I am CEO", "feliz.jovanni@gmail.com", "https://media.licdn.com/dms/image/D4E03AQFmqmxDnBFpjw/profile-displayphoto-shrink_800_800/0/1695423491664?e=1706140800&v=beta&t=1YCpHpITTc_ME9YctHk0Vte8hhYzmhieSmxiH258VA4", true, "Jovanni Feliz", 6037779999L, "zcxxFyDPReWizoUPtyPru9w072J3" },
                    { 2, "I am a Customer", "MahlJ@gmail.com", "https://img.freepik.com/free-photo/young-bearded-man-with-striped-shirt_273609-5677.jpg?w=2000", false, "John Mahlar", 4324566788L, "p84DEdgj4kYhU4VKJfFqZX7unHD3" }
                });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "id", "country", "customer_email", "customer_name", "customer_phone_number", "customer_uid", "date_time", "order_status_id", "payment_id", "payment_type_id", "revenue", "shipping_method", "state", "street_address", "town_city", "zipcode" },
                values: new object[] { 1, "USA", "MahlJ@gmail.com", "John Mahlar", 4324566788L, "p84DEdgj4kYhU4VKJfFqZX7unHD3", new DateTime(2023, 11, 27, 20, 38, 52, 934, DateTimeKind.Local).AddTicks(6413), 2, 1, null, 581.99000000000001, "Standard", "MS", "431 Grove Ave", "Salt Lake City", 37205 });

            migrationBuilder.CreateIndex(
                name: "ix_orders_order_status_id",
                table: "orders",
                column: "order_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_orders_payment_type_id",
                table: "orders",
                column: "payment_type_id");

            migrationBuilder.AddForeignKey(
                name: "fk_orders_order_statuses_order_status_id",
                table: "orders",
                column: "order_status_id",
                principalTable: "order_statuses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_orders_payment_types_payment_type_id",
                table: "orders",
                column: "payment_type_id",
                principalTable: "payment_types",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orders_order_statuses_order_status_id",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "fk_orders_payment_types_payment_type_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "ix_orders_order_status_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "ix_orders_payment_type_id",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "carts",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "order_statuses",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "order_statuses",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "payment_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "payment_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "payment_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "payment_types",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "payment_types",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "order_statuses",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "customer_uid",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "customer_uid",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "payment_type_id",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "name",
                table: "order_statuses",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
