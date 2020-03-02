using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksBlogRazor.Migrations
{
    public partial class SeedBookReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 1,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://knigopoisk.org/media/books/Cv/Cvety_dlja_Jeldzhernona.jpg", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Цветы для Элджернона" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 2,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://knigopoisk.org/media/books/Br/Brem_Stoker__Drakula.jpg", new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Дракула" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 3,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://knigopoisk.org/media/books/pu/puteshestviya-gullivera--95393.jpg", new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Гулливер" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 4,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://knigopoisk.org/media/books/po/poster.png", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "40 дней" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 5,
                columns: new[] { "Description", "Genre", "Image", "MyRating", "ReviewDateCreated", "Title" },
                values: new object[] { "Четырехпалый Френки должен был переправить краденый алмаз из Англии в США своему боссу Эви. Но вместо этого герой попадает в эпицентр больших неприятностей.Сделав ставку на подпольном боксерском поединке,Френки попадает в круговорот весьма нежелательных событий.", "Criminal", "https://knigopoisk.org/media/books/po/poster.png", 5, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "4 месяца" });

            migrationBuilder.InsertData(
                table: "BookReviews",
                columns: new[] { "BookReviewId", "Description", "Genre", "Image", "MyRating", "Review", "ReviewDateCreated", "Title" },
                values: new object[,]
                {
                    { 6, "Четырехпалый Френки должен был переправить краденый алмаз из Англии в США своему боссу Эви. Но вместо этого герой попадает в эпицентр больших неприятностей.Сделав ставку на подпольном боксерском поединке,Френки попадает в круговорот весьма нежелательных событий.", "Criminal", "https://knigopoisk.org/media/books/po/poster.png", 5, "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "10 месяцев" },
                    { 7, "Четырехпалый Френки должен был переправить краденый алмаз из Англии в США своему боссу Эви. Но вместо этого герой попадает в эпицентр больших неприятностей.Сделав ставку на подпольном боксерском поединке,Френки попадает в круговорот весьма нежелательных событий.", "Criminal", "https://knigopoisk.org/media/books/po/poster.png", 5, "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "14 месяцев" },
                    { 8, "Дрю Деккер разговаривает по телефону с незнакомцем, будто бы попавшим не туда. Очень скоро она понимает, что её собеседник — маньяк, который хочет её убить. Дрю выбегает из дома, по пятам преследуемая маньяком. Девушке почти удаётся убежать, но её случайно сбивает машина отца…", "Comedy", "https://knigopoisk.org/media/books/go/golodnye-igry--20522.jpg", 2, "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2018, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "2 ГОДА назад" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 1,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://www.kinopoisk.ru/images/film_big/371.jpg", new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Спасти рядового Райана" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 2,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://www.kinopoisk.ru/images/film_big/401177.jpg", new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Сумерки" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 3,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://www.kinopoisk.ru/images/film_big/61237.jpg", new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Железный Человек" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 4,
                columns: new[] { "Image", "ReviewDateCreated", "Title" },
                values: new object[] { "https://www.kinopoisk.ru/images/film_big/526.jpg", new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Большой куш" });

            migrationBuilder.UpdateData(
                table: "BookReviews",
                keyColumn: "BookReviewId",
                keyValue: 5,
                columns: new[] { "Description", "Genre", "Image", "MyRating", "ReviewDateCreated", "Title" },
                values: new object[] { "Дрю Деккер разговаривает по телефону с незнакомцем, будто бы попавшим не туда. Очень скоро она понимает, что её собеседник — маньяк, который хочет её убить. Дрю выбегает из дома, по пятам преследуемая маньяком. Девушке почти удаётся убежать, но её случайно сбивает машина отца…", "Comedy", "https://www.kinopoisk.ru/images/film_big/5932.jpg", 2, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Очень страшное кино" });
        }
    }
}
