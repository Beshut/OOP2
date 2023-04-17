using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Polling;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;
using System.IO;

namespace Wine
{
    internal class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("6032456796:AAHcS2iG0LJ3CzHPwDx-4Z0hJ9rlJnSbMh8");

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));

            String message = update.Message.Text;
            long chatId = update.Message.Chat.Id;
            Boolean isfind = false;


            if (message.Equals("/start"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Описание купажного вина"},
                    new KeyboardButton[] {"Технология купажирования домашнего вина"},
                    new KeyboardButton[] {"Лучшие красные купажные вина 2022 года"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Рад вас приветсвовать", replyMarkup: start);
            }

            if (message.Equals("Описание купажного вина"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Купажное вино – что это?"},
                    new KeyboardButton[] {"Основные виды купажа"},
                    new KeyboardButton[] {"Условия хранения"},
                    new KeyboardButton[] {"Главное меню"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
            }

            if (message.Equals("Технология купажирования домашнего вина"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Первый способ"},
                    new KeyboardButton[] {"Второй способ"},
                    new KeyboardButton[] {"Третий способ"},
                    new KeyboardButton[] {"Главное меню"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
            }

            if(message.Equals("Лучшие красные купажные вина 2022 года"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Лучшее в целом"},
                    new KeyboardButton[] {"Лучшее до $20"},
                    new KeyboardButton[] {"Лучшее соотношение цены и качества"},
                    new KeyboardButton[] {"Лучшая Калифорния"},
                    new KeyboardButton[] {"Главное меню"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
            }

            if (message.Equals("Главное меню"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Описание купажного вина"},
                    new KeyboardButton[] {"Технология купажирования домашнего вина"},
                    new KeyboardButton[] {"Лучшие красные купажные вина 2022 года"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Возврат на главное меню", replyMarkup: start);
            }

            if (message.Equals("Купажное вино – что это?"))
            {
                isfind = true;
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Купажное вино – что это?\n\nДанный продукт получают от смеси сортов сырья. " +
                    "Это связано в различном химическом составе плодов и вкусовых качествах отдельно взятого сока. " +
                    "При выращивании виноградной лозы наблюдаются отличия в грунте, климатических условиях, степени зрелости плодов во время сбора. " +
                    "Даже собранные с одного куста виноград, но в разное время, может сильно отличаться по содержанию сахара и других компонентов. " +
                    "В итоге ягоды отличаются не только по вкусу, но и по аромату, имеют разные органолептические свойства, особенно если виноград выращивается в промышленных масштабах.");
            }

            if (message.Equals("Основные виды купажа"))
            {
                isfind = true;
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Основные виды купажа\n\nВинтажные купажи (vintage wine blends)\n" +
                    "Это купаж нескольких сортов ягод собранных в разное время года. " +
                    "Например, алкоголь сделан из сортов Мерло и Шираз, полученных в одном году. " +
                    "Также встречаются экземпляры, где содержится набор из более десяти сортов. " +
                    "Ярким видом является вино Шатонеф дю Пап из 13 сортов.\n\nБезвинтажные купажи (non-vintage blends)\n" +
                    "Это напитки, произведенные из винограда собранного в разные года. " +
                    "Этот купаж позволяет сбалансировать вкус, аромат и прочих качеств. " +
                    "При производстве данного вида купажей используется специальная маркировка, а на этикетке указывается год сбора урожая.");
            }

            if (message.Equals("Условия хранения"))
            {
                isfind = true;
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Условия хранения\n\nХранят домашнее купажированное вино в стеклянных, непрозрачных бутылках, которые предварительно промыты и хорошо высушены. " +
                    "Бутылки с вином хорошо закупоривают, оборачивают плотной тканью и опускают на 20 минут в горячую воду (температура 60 градусов). " +
                    "После этой обработки купажированое вино храниться как обычное в погребе или холодильнике. " +
                    "При правильном хранении срок годности продукта может быть неограничен.");
            }

            if (message.Equals("Первый способ"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\Users\\User\\Documents\\Sound\\Пение соловья.mp3");
                var audio = new InputOnlineFile(sr.BaseStream, "Для атмосферы часть 1.mp3");
                await botClient.SendAudioAsync(chatId: chatId, audio: audio, caption: "Первый способ\n\nПервый способ заключается в следующем:\n" +
                    "1)собрать необходимое количество сортов винограда, которые понадобятся для приготовления взвесить компоненты. Перемешать и перемолоть;\n" +
                    "2)выжать из полученной массы сок и оценить его вкусовые качества;\n" +
                    "3)скорректировать вкус при помощи воды, сахара или кислоты;\n" +
                    "4)оставить сусло для брожения.\n\n" +
                    "Это самый простой способ, но он имеет недостатки:\n" +
                    "1)не все ягоды созревают одновременно;\n" +
                    "2)плоды неодинаково отдают сок.\n\n" +
                    "Конечно, можно решить проблему, дав мезге забродить, но при этом можно получить слизь из невызревших плодов, что отрицательно повлияет на вкусовые качества конечного продукта.");
            }

            if (message.Equals("Второй способ"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\Users\\User\\Documents\\Sound\\Пение птиц на заре.mp3");
                var audio = new InputOnlineFile(sr.BaseStream, "Для атмосферы часть 2.mp3");
                await botClient.SendAudioAsync(chatId: chatId, audio: audio, caption: "Второй способ\n\n" +
                    "Согласно второму способу, требуемое количество сока получают из ягод разных сортов по отдельности. " +
                    "После сбора сока определяют сахаристость и кислотность и также по отдельности исправляют вкус. " +
                    "Затем из жидкостей готовят сусла в зависимости от того, какое нужно сделать вино — сладкое, крепкое либо столовое. " +
                    "Готовые сусла соединяют в одной емкости друг с другом и оставляют для брожения.");
            }

            if (message.Equals("Третий способ"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\Users\\User\\Documents\\Sound\\Красивое пение зяблика.mp3");
                var audio = new InputOnlineFile(sr.BaseStream, "Для атмосферы часть 3.mp3");
                await botClient.SendAudioAsync(chatId: chatId, audio: audio, caption: "Третий способ\n\n" +
                    "При третьем способе смешивают готовые вина, но у этого метода есть недостаток – можно испортить продукт из-за несочитаемости вкусов.");
            }

            if (message.Equals("Лучшее в целом"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\Users\\User\\Pictures\\Лаво Расто 2017.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Лаво Расто 2017.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Лучший в целом: Лаво Расто 2017\n\nЭта бутылка из Лаво — французская Долина Роны в отличной форме: пьянящий союз гренаша и сиры, двух местных фаворитов. " +
                    "Небольшой городок Расто стал очень востребованным участком винодельческой недвижимости для производителей Шатонеф-дю-Пап, стремящихся воспроизвести популярный аромат купажа Роны, любимый во всем мире. " +
                    "Лаво также получает поддержку от легендарного винного консультанта Стефана Деренонкура, который консультирует виноградники от Франции до Калифорнии и Ближнего Востока. " +
                    "Это Расто 2017 года богатое, бархатистое и ароматное, и, чтобы подсластить сделку, это вино с поразительной ценностью. " +
                    "Есть за что любить.");
            }


            if (message.Equals("Лучшее до $20"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\Users\\User\\Pictures\\Famille Perrin Vinsobres Les Cornuds 2017.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Famille Perrin Vinsobres Les Cornuds 2017.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Лучшее до $20: Famille Perrin Vinsobres Les Cornuds 2017\n\n" +
                    "История виноделия семьи Перрин, расположенной вдоль долины Южной Роны во Франции, насчитывает пять поколений — по французским меркам это приличное долголетие. " +
                    "Эта бутылка Les Cornuds представляет собой смесь наполовину гренаша и наполовину сиры, двух сортов, которые процветают в этом регионе. " +
                    "А урожай 2017 года выиграл от рекордно высокого засушливого года с небольшим урожаем винограда, но интенсивным, элегантным вкусом.");
            }

            if (message.Equals("Лучшее соотношение цены и качества"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\Users\\User\\Pictures\\Bodegas Muga Reserva 2016.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Bodegas Muga Reserva 2016.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Лучшее соотношение цены и качества: Bodegas Muga Reserva 2016\n\n" +
                    "Ведущим сортом этой смеси является иберийский фаворит темпранильо, и его доля в этом кюве составляет более двух третей. " +
                    "Bodegas Muga — одна из жемчужин северного побережья Испании, и причина этого очевидна в Reserva 2016 года. " +
                    "Со смесью ароматов красных фруктов и темных фруктов, это вино является естественной парой с мясными деликатесами. " +
                    "Это высококачественное красное вино, но, поскольку Bodegas Muga производила внушительные запасы, это также отличное вино по соотношению цена-качество.");
            }

            if (message.Equals("Лучшая Калифорния"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\Users\\User\\Pictures\\Paraduxx, 2017 г..jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Paraduxx, 2017 г.");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Лучшая Калифорния: фирменный красный цвет Paraduxx, 2017 г.\n\n" +
                    "Что такое настоящая красная смесь долины Напа, в которой нет большого процента знаменитого каберне-совиньона? " +
                    "Этот дурман от Paraduxx, под флагом портфолио Duckhorn Vineyards, настолько Напа, насколько может быть красная смесь. " +
                    "Это почти наполовину каберне, но также включает в себя пти вердо, зинфандель и даже немного темпранильо. " +
                    "В целом фруктовый вкус со сливочными танинами.");
            }

            if (!isfind)
            {
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Мне не понятно ваше сообщение");
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { },
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}
