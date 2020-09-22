using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Andrea.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id_About = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_About = table.Column<string>(nullable: true),
                    Img_About = table.Column<string>(nullable: true),
                    Description_About = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id_About);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id_Cat = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Cat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id_Cat);
                });

            migrationBuilder.CreateTable(
                name: "Contact_Infos",
                columns: table => new
                {
                    Id_Info = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_Infos", x => x.Id_Info);
                });

            migrationBuilder.CreateTable(
                name: "Contact_Posts",
                columns: table => new
                {
                    Id_Contact = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(nullable: true),
                    SenderEmail = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Msg_Contact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_Posts", x => x.Id_Contact);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id_Blog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Blog = table.Column<string>(nullable: true),
                    Description_Blog = table.Column<string>(nullable: true),
                    Img_Blog = table.Column<string>(nullable: true),
                    Blogger_Name = table.Column<string>(nullable: true),
                    Blogger_Img = table.Column<string>(nullable: true),
                    Blogger_Description = table.Column<string>(nullable: true),
                    Tag1 = table.Column<string>(nullable: true),
                    Tag2 = table.Column<string>(nullable: true),
                    Tag3 = table.Column<string>(nullable: true),
                    Tag4 = table.Column<string>(nullable: true),
                    Tag5 = table.Column<string>(nullable: true),
                    Tag6 = table.Column<string>(nullable: true),
                    Date_Post = table.Column<DateTime>(nullable: false),
                    Id_Cat = table.Column<int>(nullable: false),
                    categoryId_Cat = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id_Blog);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Categories_categoryId_Cat",
                        column: x => x.categoryId_Cat,
                        principalTable: "Categories",
                        principalColumn: "Id_Cat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id_Comment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment_Name = table.Column<string>(nullable: true),
                    Comment_Mail = table.Column<string>(nullable: true),
                    Comment_WebSite = table.Column<string>(nullable: true),
                    Comment_Msg = table.Column<string>(nullable: true),
                    Comment_DatePost = table.Column<DateTime>(nullable: false),
                    blogPostId_Blog = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id_Comment);
                    table.ForeignKey(
                        name: "FK_Comments_BlogPosts_blogPostId_Blog",
                        column: x => x.blogPostId_Blog,
                        principalTable: "BlogPosts",
                        principalColumn: "Id_Blog",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id_Reply = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reply_Name = table.Column<string>(nullable: true),
                    Reply_Mail = table.Column<string>(nullable: true),
                    Reply_Msg = table.Column<string>(nullable: true),
                    Reply_DatePost = table.Column<string>(nullable: true),
                    Id_Comment = table.Column<int>(nullable: false),
                    commentId_Comment = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id_Reply);
                    table.ForeignKey(
                        name: "FK_Replies_Comments_commentId_Comment",
                        column: x => x.commentId_Comment,
                        principalTable: "Comments",
                        principalColumn: "Id_Comment",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_categoryId_Cat",
                table: "BlogPosts",
                column: "categoryId_Cat");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_blogPostId_Blog",
                table: "Comments",
                column: "blogPostId_Blog");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_commentId_Comment",
                table: "Replies",
                column: "commentId_Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contact_Infos");

            migrationBuilder.DropTable(
                name: "Contact_Posts");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
