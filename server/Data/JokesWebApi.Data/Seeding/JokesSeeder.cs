namespace JokesWebApi.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using JokesWebApi.Data.Models;

    internal class JokesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Jokes.Any())
            {
                return;
            }

            var categories = new List<Category>();

            // ПОЛИТИЧЕСКИ
            categories.RemoveAll(x => true);
            var politicsCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "политически");
            categories.Add(politicsCategory);
            var politicJokes = new List<Joke>
            {
                new Joke
                {
     Content = "Белият дом. На вратата се звъни. Тръмп отваря и вижда Байдън с непознат мъж:\n- Здравейте, аз съм Жоро Игнатов от \"Съдебен спор\"...",
     Categories = categories,
                },
                new Joke
                {
     Content = "Бочко отишъл в подножието на Рила с джипката, слязъл и посочил Мусала:\n\"Ей тоя връх ГЕРБ го вдигна. Лично разпоредих да се отпуснат парите. Допреди ГЕРБ тука имаше само едно кално поле.\"",
     Categories = categories,
                },
                new Joke
                {
     Content = "Във Виетнам е работела фабрика, която перяла, изсушавала и отново продавали стари използвани презервативи.\nЩе е много трудно да се намери по-точно описание за работата на нашата Централна Избирателна Комисия.",
     Categories = categories,
                },
                new Joke
                {
     Content = "ГЕОМЕТРИЯ ЗА ДЕПУТАТИ\nВ триъгълника на властта в България има поне два тъпи ъгли.\nКои са те?\nОтговор А: Ъгъл ТКП и ъгъл ТБТ.\nОтговор Б: Това не може да е триъгълник (Питагор).\nОтговор В: Това не може да е влст.",
     Categories = categories,
                },
                new Joke
                {
     Content = "Али Баба и четиридесет е разбойника по български:\nАли Баба и разбойниците му крадат и от богати, и от бедни, а парите трупат в шкафчето.",
     Categories = categories,
                },
                new Joke
                {
     Content = "- Кате, как кръстихте детето?\n- Бойко - да му е пълно шкафчето!",
     Categories = categories,
                },
                new Joke
                {
     Content = "- Защо Хитлер е игреаел шах само с белите фигури?\n- Защото бил расист.",
     Categories = categories,
                },
                new Joke
                {
     Content = "- А бе наборе, знаеш ли че пенсиите ни били неприлично по-високи от заплатите на правителството и парламента?\n- И какво сега ще ни ги зимат ли?\n- Не бе, за сега щели само да ни плашат от телевизора и да ни глобяват.",
     Categories = categories,
                },
                new Joke
                {
     Content = "18 годишните в щатите:\n- Може ли цигара? А бира?\nАмериканското правителство:\n- Не, но може да отидете на война с Иран.",
     Categories = categories,
                },
                new Joke
                {
     Content = "Само по-старите хора си спомнят нова година без нова цена на водата.",
     Categories = categories,
                },
            };
            await dbContext.Jokes.AddRangeAsync(politicJokes);

            // ПРИКАЗНИ
            categories.RemoveAll(x => true);
            var taleCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "приказни");
            categories.Add(taleCategory);
            var taleJokes = new List<Joke>
            {
         new Joke
         {
     Content = "Лапландия. Добрият старец обяви, че тази година ще работи от вкъщи в празничната нощ:\n\"В рискова група съм. Не си знам нито годините, нито килограмите. Работя с много китайска продукция, честно казано си ме е шубе\" - призна Дядо Коледа във видео обръщение към децата.",
     Categories = categories,
         },

         new Joke
        {
     Content = "Състезават се Брус Ли, Чък Норис и Милко Калайджиев кой ще изкара огромен и страшен паяк от пещерата.\nВлиза Брус Ли, чува се трясък, викове и... Брус Ли излиза без една ръка, казвайки:\n- Бахти к'ъв паяк?!\nВлиза Чък Норис, чува се трясък, викове и... Чък Норис се влачи навън без един крак, казвайки:\n- Бахти к'ъв паяк?!\nВлиза Милко, чува се трясък, викове и... излиза паякът, казвайки:\n- Бахти селянина?!",
     Categories = categories,
        },

         new Joke
        {
     Content = "В едно царство пристигнал с колесницата си граматикът-нацист. Той поправял всички хора - с или без повод. Накрая хората се уморили от него, хванали го и го завели на съд при царя. Царят бил мъдър и попитал:\n- Какво да правя с теб? Да те изгоня от царството или да наредя твоето обийство?\n- \"У\"бийство! - обичайно го поправил граматикът-нацист.", Categories = categories,
        },

         new Joke
        {
     Content = "- Тате, тате, има ли разумни цивилизации, там сред звездите?\n- Разбира се, че има.\n- Ами защо тогава не се сързват с нас?\n- Защото са разумни.", Categories = categories,
        },

         new Joke
        {
     Content = "Искам в паралелна Вселена, в която не аз съм длъжен на банката, а банката на мен...", Categories = categories,
        },

         new Joke
        {
     Content = "Тръгнали на война братята Агамемнон и Менелай, и братовчедите им Тебелай и Неголай.", Categories = categories,
        },

         new Joke
        {
     Content = "Синус, косинус, тангенс и техни приятели се забавляват и танцуват на парти, а експоненциалната функция седи в ъгъла сама.\nКосинус отишъл при нея и я попитал:\n- Защо седиш сама? Защо не се интегрираш?\nА тя отвърнала:\n- Опитах, нищо не се промени.", Categories = categories,
        },

         new Joke
        {
     Content = "Един чеченец хваща златната рибка. Оглежда я любопитно, не знае какво да прави с нея.\n- Е, желание няма ли да си пожелаеш.\n- Е как така?\n- Ами, как да ти кажа, вчера ме хвана един азербайджанец и поиска от мен един милион долара. Речено-сторено, дадох му. А ти какво искаш?\n- Адреса на азербайджанеца!", Categories = categories,
        },

         new Joke
        {
     Content = "Дивия запад. Излиза един от кръчма, бил си оставил коня отвън. Гърми с пистолета нагоре и пита:\n- Кой ми е боядисал коня в зелемо?\nСтава един едър и нацепен мъж и изръмжава:\n- Аз!\n- Аа, само да кажа че е изсъхнал и е готов за лакиране...", Categories = categories,
        },

         new Joke
        {
     Content = "- Защо Хари Потър има светкавица на челото?\n- Защото го е блъснал Опел...",
     Categories = categories,
        },
            };
            await dbContext.Jokes.AddRangeAsync(taleJokes);

            // BIG BROTHER
            categories.RemoveAll(x => true);
            var bigBrotherCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "big brother");
            categories.Add(taleCategory);
            var bigBrotherJokes = new List<Joke>
            {
             new Joke{
     Content = "Как се превежда Динко на английски?\n- Mister.",
     Categories = categories,
    },
             new Joke{
     Content = "- Какъв подарък се надява българският народ да получи за Коледа? Евгени Минчев?\n- Евтаназия!",
     Categories = categories,
    },
             new Joke{
     Content = "VIP Brother е лек срещу депресия. Гледането на предаването уверява депресираните, че не те са най-тъпите хора в България и повишава самочувствието.",
     Categories = categories,
    },
             new Joke{
     Content = "Cекретарка:\n- Цифричките на клавиатурата ми не работят!\nАдминистратор:\n- Натиснете NumLock.\nСекретарка:\n- Натиснах, не помага!\nАдминистратор:\n- Чай? Кафе?\nСекретарка:\n- Не може ли направо с*кс?\nАдминистратор:\n- Питам какво разля на клавиатурата!",
     Categories = categories,
    },
             new Joke{
     Content = "В казино, сайт за залагане или тото можеш и да загубиш пари, но гледайки ВИП/БИГ брадър ГАРАНТИРАНО губиш... мозъчни клетки!",
     Categories = categories,
    },
             new Joke{
     Content = "Терористичната организация Ал Кайда пое отговорност за излъчването на ВИП Брадър.",
     Categories = categories,
    },
             new Joke{
     Content = "Съпруг тръгва за командировка, но един час по-късно се връща ядосан, веднага започва да се рови из шкафовете, под леглото, на балкона, а жена му обидена казва:\n- Но кой ще ме иска мене, стара и дебела?\n- Виждала ли си ми стария, дебел портфейл?",
     Categories = categories,
    },
             new Joke {
     Content = "ЧЪК НОРИС може да изпържи картофи без да включва котлона",
     Categories = categories,
    },
            };
            await dbContext.Jokes.AddRangeAsync(bigBrotherJokes);

            // MICROSOFT
            categories.RemoveAll(x => true);
            var microsoftCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "microsoft");
            categories.Add(microsoftCategory);
            var microsoftJokes = new List<Joke>
            {
             new Joke{
     Content = "С Бил Гейтс общия ни капитал възлиза на 102,1 милиарда долара и 200 лева...",
     Categories = categories,
    },
    new Joke{
     Content = "Тя:\n- Ще дойдеш ли в къщи довечера да ми преинсталираш Windows-a ?\nТой:\n- Ама ти току що си купи лаптопа. Не ти трябва преинсталация.\nТя:\n- Ти тъп ли си или не разбираш от намеци?\nТой:\n- Ти не можеш един уиндоус да преинсталираш, пък аз съм бил тъп.",
     Categories = categories,
    },
    new Joke{
     Content = "Microsoft така и не успя да накара ползвателите да се откажат от Windows XP, затова реши да пусне безплатна програма за обновление под името WannaCry.",
     Categories = categories,
    },
    new Joke{
     Content = "Двама крадци влезнали в къщата на Бил Гейтс през нощта.\n- Нека първо да вземем бижутата! - подшушнал единият.\n- Идиот! - разгневил се другият. - Първо място ще му инсталираме Linux!",
     Categories = categories,
    },
    new Joke{
     Content = "\"Винаги избирам един мързелив човек да свърши трудната работа, защото той ще намери един лесен начин да я постигне.\"\n(C) Бил Гейтс",
     Categories = categories,
    },
    new Joke{
     Content = "От \"Windows\" съобщиха, че разработват нова версия за България, в която до възможностите \"Yes\", \"No\" i \"Cancel\" ще има още една- \"През оная ми работа ми е, я се скривай!\"",
     Categories = categories,
    },
    new Joke{
     Content = "Фен на Microsoft и Linux разговарят. Първият:\n- Имам един гаден проблем с Windows 98. В някои случаи, като му дам Shutdown, просто забива и онемява тотално.\n- Абе, колко пъти да ти набивам в главата, че Microsoft и продуктите им за нищо не стават?! Пълни некадърници и ламери! Годината е била 1998, а те не са знаели даже кое е горе и кое е долу - даваш му Shut down, разбира Shut up!",
     Categories = categories,
    },
    new Joke{
     Content = "- Как ли се е родило тъй известното “Win Sux”, употребявано толкова често от Linux-феновете?\n- Именно от тях и от обичния им Linux е родено. Нали ги знаеш, навсякъде вмъкват по нещо от любимата си система: Linux -> Winux -> WinSux.",
     Categories = categories,
    },
    new Joke{
     Content = "Проблемите на софтуерния свят ще свършат, когато за Бил Гейтс се заговори: “И едно време бил Гейтс...”.",
     Categories = categories,
    },
    new Joke{
     Content = "- По какво си приличат Windows с презерватива?\n- Никой не ги харесва, но мнозина ги използват.",
     Categories = categories,
    }
            };
            await dbContext.Jokes.AddRangeAsync(microsoftJokes);

            // SMS
            categories.RemoveAll(x => true);
            var smsCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "sms");
            categories.Add(microsoftCategory);
            var smsJokes = new List<Joke>
            {
             new Joke{
     Content = "Един мъж, вече уморен да прави намеци на една упорита млада дама, ѝ пише:\n- Хайде, дори и за пари, да спим заедно!\nТя:\n- Нямам пари.\nТой:\n- Ще се разплача!\nТя:\n- Не плачи, всичко ще бъде наред...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS разговор между любовници. Мъжът:\n- Ще ти дойда на гости! Приготви чай!\nНейният отговор:\n- Ще мина да те взема! Приготви патка...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS чат на двама влюбени!\nТя:\n- Миличък, баща ми си е контузил крака и лежи и не може да ходи. Идвай при мен. Няма да ни пречи!\nТой:\n- Много ми се иска да дойда, обаче много ме боли мястото, където баща ти си контузи глезена и пръстите!",
     Categories = categories,
    },
    new Joke{
     Content = "Внимание! В мрежата се е появила нов вид измама!\nЗа да прочетете повече, изпратете SMS на номер 1096 с текст...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS от жената:\nСкъпи, ако се усмихваш, изпрати ми твоите усмивки. Ако спиш, изпрати ми твоите сънища. Ако плачеш, изпрати ми твоите сълзи. Обичам те!\nSMS отговор от мъжа:\nВ тоалетната съм. Какво да ти изпратя?",
     Categories = categories,
    },
    new Joke{
     Content = "- Скъпа, кажи нещо за четене?\n- Прочети \"Отче наш\", докато не приключа с четенето на sms-ите в телефона ти...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS: Aни, купих шампанско, ягоди и течен шоколад. Апартаментът е наш, чакам те!\nSMS: Ани я няма. Аз съм мъжът ѝ! По-добре купи бира, цаца и вазелин.",
     Categories = categories,
    },
    new Joke{
     Content = "SMS кореспонденция:\n- Скъпи, вечерята е готова, апартаментът е изчистен, дрехите са изпрани, а аз съм чисто гола.\n- Аз отидох на риба.",
     Categories = categories,
    },
    new Joke{
     Content = "SMS от бившия ми съпруг:\n\"Вчера те видях! Красива, засмяна, пияна. 2 години, откакто се разделихме, и ти, ку*ко, все още празнуваш!\"",
     Categories = categories,
    },
    new Joke{
     Content = "Днес получих следния SMS: \"Аз живея в къщата отсреща :) Хайде да се запознаем!\"\nАз отговорих: \"Аз живея срещу моргата и някак си не ме блазни предложението.\"",
     Categories = categories,
    }
            };
            await dbContext.Jokes.AddRangeAsync(microsoftJokes);

            // АВТО
            categories.RemoveAll(x => true);
            var autoCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "авто");
            categories.Add(autoCategory);
            var autoJokes = new List<Joke>
            {
             new Joke{
     Content = "Един мъж, вече уморен да прави намеци на една упорита млада дама, ѝ пише:\n- Хайде, дори и за пари, да спим заедно!\nТя:\n- Нямам пари.\nТой:\n- Ще се разплача!\nТя:\n- Не плачи, всичко ще бъде наред...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS разговор между любовници. Мъжът:\n- Ще ти дойда на гости! Приготви чай!\nНейният отговор:\n- Ще мина да те взема! Приготви патка...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS чат на двама влюбени!\nТя:\n- Миличък, баща ми си е контузил крака и лежи и не може да ходи. Идвай при мен. Няма да ни пречи!\nТой:\n- Много ми се иска да дойда, обаче много ме боли мястото, където баща ти си контузи глезена и пръстите!",
     Categories = categories,
    },
    new Joke{
     Content = "Внимание! В мрежата се е появила нов вид измама!\nЗа да прочетете повече, изпратете SMS на номер 1096 с текст...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS от жената:\nСкъпи, ако се усмихваш, изпрати ми твоите усмивки. Ако спиш, изпрати ми твоите сънища. Ако плачеш, изпрати ми твоите сълзи. Обичам те!\nSMS отговор от мъжа:\nВ тоалетната съм. Какво да ти изпратя?",
     Categories = categories,
    },
    new Joke{
     Content = "- Скъпа, кажи нещо за четене?\n- Прочети \"Отче наш\", докато не приключа с четенето на sms-ите в телефона ти...",
     Categories = categories,
    },
    new Joke{
     Content = "SMS: Aни, купих шампанско, ягоди и течен шоколад. Апартаментът е наш, чакам те!\nSMS: Ани я няма. Аз съм мъжът ѝ! По-добре купи бира, цаца и вазелин.",
     Categories = categories,
    },
    new Joke{
     Content = "SMS кореспонденция:\n- Скъпи, вечерята е готова, апартаментът е изчистен, дрехите са изпрани, а аз съм чисто гола.\n- Аз отидох на риба.",
     Categories = categories,
    },
    new Joke{
     Content = "SMS от бившия ми съпруг:\n\"Вчера те видях! Красива, засмяна, пияна. 2 години, откакто се разделихме, и ти, ку*ко, все още празнуваш!\"",
     Categories = categories,
    },
    new Joke{
     Content = "Днес получих следния SMS: \"Аз живея в къщата отсреща :) Хайде да се запознаем!\"\nАз отговорих: \"Аз живея срещу моргата и някак си не ме блазни предложението.\"",
     Categories = categories,
    }
            };
            await dbContext.Jokes.AddRangeAsync(autoJokes);

            // БЛОНДИНКИ
            categories.RemoveAll(x => true);
            var blondsCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "блондинки");
            categories.Add(blondsCategory);
            var blondsJokes = new List<Joke>
            {
             new Joke{
     Content = "Продавач към богата блондинка:\n- Госпожице, купете си оригинален китайски порцелан!\n- Благодаря, писнало ми е от китайски кич.\n- Какъв кич, това е рядък артефакт – първи век, династията Мин!\n- Ето на, какъв боклук трябва да е това, че да виси толкова време по складовете…",
     Categories = categories,
    },
    new Joke{
     Content = "- Защо закъсняваш с цял час?\n- Красивите жени могат да закъсняват.\n- Така е, но ти защо закъсняваш?",
     Categories = categories,
    },
    new Joke{
     Content = "Питат блондинка:\n- Вие девствена ли сте?\n- Слава Богу още не.",
     Categories = categories,
    },
    new Joke{
     Content = "Лежи брюнетка на болничното легло със сътресение на мозъка и си мисли: \"Ако бях блондинка, нямаше да се търкалям тук...\".",
     Categories = categories,
    },
    new Joke{
     Content = "Разговор между блондинки:\n- Мъжът ми построи къща!\n- Колко стаи?\n- Една.\n- Е, идеално... то по-малко и няма смисъл.",
     Categories = categories,
    },
    new Joke{
     Content = "Блондинка говори на приятелка:\n- Аз съм толкова уникална, че на 14 години ме записаха в Червената книга!\n- Глупачка, тогава ти издадоха паспорт...",
     Categories = categories,
    },
    new Joke{
     Content = "Блондинка държи главата си над включена печка. Приятелката й я пита:\n- Защо си се навела над тази печка?\n- Защото ме посъветваха да си опичам акъла...",
     Categories = categories,
    },
    new Joke{
     Content = "Две блондинки се качват в двуетажен автобус. Едната се покатерва на втория етаж, след което веднага се обръща и започва да слиза.\n- Муци, слизай бързо, горе няма шосрьор!",
     Categories = categories,
    },
    new Joke{
     Content = "Продавач към блондинка в магазина:\n- Мога ли да ви помогна?\n- Да, търся подарък за най-близкия човек.\n- Ами... може би лаптоп?\n- Не, вече си имам лаптоп.",
     Categories = categories,
    }
            };
            await dbContext.Jokes.AddRangeAsync(blondsJokes);

            // ГРАФИТИ
            categories.RemoveAll(x => true);
            var grafitsCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "блондинки");
            categories.Add(grafitsCategory);
            var grafitsJokes = new List<Joke>
            {
             new Joke{
     Content = "По празниците са се навъдили молци-мутанти. Стеснили са всичките дрехи в гардероба ми.",
     Categories = categories,
    },
    new Joke{
     Content = "Надпис в школата за парашутисти:\n\"Уважаеми курсанти, изходът се намира на петия етаж!\"",
     Categories = categories,
    },
    new Joke{
     Content = "Надписът на стената в подлеза казваше доста повече за Катя отколкото този на стената й във Фейсбук.",
     Categories = categories,
    },
    new Joke{
     Content = "Интелигентността е като бельото, важно е да го имаш, но няма нужда да го показваш!",
     Categories = categories,
    },
    new Joke{
     Content = "Надпис на мост в Сърбия: \"Колумбе, йебем ти и откритието!\"",
     Categories = categories,
    },
    new Joke{
     Content = "Не искам да защитавам чалгата, но като беше с Алисия, Божинов играеше не във Виченца, а в Ювентус!?!",
     Categories = categories,
    },
    new Joke{
     Content = "Ако Фуагра е гъши дроб, то Виагра е дроб от некво друго животно...",
     Categories = categories,
    },
    new Joke{
     Content = "\"Хепиенд няма да има\".\nПодпис:Архангел Михаил.",
     Categories = categories,
    },
    new Joke{
     Content = "Отлага се пролетния футболен полусезон, защото няма да има публика - ултрасите са заети да вандалстват по улиците.",
     Categories = categories,
    },
    new Joke{
     Content = "Бойко Борисов умислен гледа протестите по новините. Замисли се: \"Е, протестират, но не е проблем. Мразят ме само тези, които използват електричество. Всички останали още ме обичат.\"",
     Categories = categories,
    }
            };
            await dbContext.Jokes.AddRangeAsync(grafitsJokes);

            // ЖИВОТНИ
            categories.RemoveAll(x => true);
            var animalsCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "животни");
            categories.Add(animalsCategory);
            var animalsJokes = new List<Joke>
            {
                 new Joke{
     Content = "Една крава се покатерила на едно дърво. Минал един един червей и я пита:\n- Ама какво правиш там горе?\n- Ще ям ябълки.\n- Ама това е круша.\n- Нищо - аз си нося.",
     Categories = categories,
    },
    new Joke{
     Content = "Върви си Червената шапчица из гората. Изведнъж от храстите се показва главата на Кумчо Вълчо:\n- Къде си тръгнала, Червена шапчице? Навярно при баба си?\n- Да.\n- А в кошницата навярно имаш козунак?\n- Да.\n- И навярно е загърнат в хартия?\n- Да.\n- Дай ми хартията, много ти се моля!",
     Categories = categories,
    },
    new Joke{
     Content = "Майна в зоомагазин:\n-Да въ питам, колко е пипигала ?\nПродавача:\n-1000 лева\n-Въъъъй мноо скъпо, ва !\nПапагала:\n-Какво скъпо, бе ?! Аз говоря български по-добре от тебе !",
     Categories = categories,
    },
    new Joke{
     Content = "- По какво се различава опасният кърлеж от безопасния?\n- Ако видите, че кърлежът се е забил и смуче от някой, то този кърлеж е безопасен за Вас!",
     Categories = categories,
    },
    new Joke{
     Content = "- Дадох на кучето на една позната да опита бира. Сега всеки ден му давам, пропи се.\n- Не му давай тогава.\n- Не мога, иначе хапе!",
     Categories = categories,
    },
    new Joke{
     Content = "- Колата никога няма да замени коня! - казала кобилата...",
     Categories = categories,
    },
    new Joke{
     Content = "Бълха си намерила работа. На следващия ден не дошла на работа и шефът я пита:\n- Какво стана?\n- Пуснахте ме в мустаците на Петров. Петров пуши, а аз имам астма!\n- Добре! Пращаме те в бикините на Сашка.\nНа следващия ден бълхата отново не дошла на работа.\n- Какво стана? - питал я шефът.\n- Сложихте ме в бикините на Сашка. Заспах в шортите на Сашка, а се събудих по мустаците на Петров. Петров пуши, а аз имам астма!",
     Categories = categories,
    }
            };
            await dbContext.Jokes.AddRangeAsync(animalsJokes);

            // ЗНАЕТЕ ЛИ ЧЕ
            categories.RemoveAll(x => true);
            var doYouKnowThatCategory = dbContext.Categories.FirstOrDefault(x => x.Name.ToLower() == "знаете ли че...");
            categories.Add(doYouKnowThatCategory);
            var doYouKnowThatJokes = new List<Joke>
            {
                 new Joke{
     Content = "Ако не са те били в ареста на полицията, значи си малък за нея.",
     Categories = categories,
    },
    new Joke{
     Content = "- Как е на английски \"Харакири с телефон\" ?\n- Селфи!\nБоцю Бодилков",
     Categories = categories,
    },
    new Joke{
     Content = "Знаете ли на какво приличат мъжете с големи бради и маски.\nНа реклама за дамско бельо през 60 те години на 20 век.",
     Categories = categories,
    },
    new Joke{
     Content = "1980 г. - хората в бъдещето ще живеят на други планети\n2020 г. - как да си мием ръцете правилно",
     Categories = categories,
    },
    new Joke{
     Content = "Плюсове и минуси в приготвянето на храната:\n- Плюс - храната. Минус - приготвянето.",
     Categories = categories,
    },
    new Joke{
     Content = "Сериозни отношения са тези, когато не я викаш у вас да гледате филм, а сериал.",
     Categories = categories,
    },
    new Joke{
     Content = "Томас Кук обяви на летуващите туристи, че могат да си получат парите в клоновете на КТБ, защото са застраховани в Олимпик...",
     Categories = categories,
    },
    new Joke{
     Content = "При ипотека купуваш един апартамент за себе си и един за банката...",
     Categories = categories,
    },
    new Joke{
     Content = "Женствеността не е в носенето на поли, рокли, високи токове и т.н. За да си истинска жена, трябва да носиш злобата в себе си!",
     Categories = categories,
    },
    new Joke{
     Content = "В борбата с корема, корема винаги е крачка напред...",
     Categories = categories,
    }
            };
            await dbContext.Jokes.AddRangeAsync(doYouKnowThatJokes);

            
        }
    }
}
