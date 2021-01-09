﻿namespace Lunr.Globalization
{
	internal static class WordCharacters
	{
		public const string Arabic =
			"، اض امين اه اها اي ا اب اجل اجمع اخ اخذ اصبح اضحى اقبل اقل اكثر الا ام اما امامك امامك امسى اما ان انا انت انتم انتما انتن انت انشا انى او اوشك اولئك اولئكم اولاء اولالك اوه اي ايا اين اينما اي ان اي اف اذ اذا اذا اذما اذن الى اليكم اليكما اليكن اليك اليك الا اما ان انما اي اياك اياكم اياكما اياكن ايانا اياه اياها اياهم اياهما اياهن اياي ايه ان ا ابتدا اثر اجل احد اخرى اخلولق اذا اربعة ارتد استحال اطار اعادة اعلنت اف اكثر اكد الالاء الالى الا الاخيرة الان الاول الاولى التى التي الثاني الثانية الذاتي الذى الذي الذين السابق الف اللائي اللاتي اللتان اللتيا اللتين اللذان اللذين اللواتي الماضي المقبل الوقت الى اليوم اما امام امس ان انبرى انقلب انه انها او اول اي ايار ايام ايضا ب بات باسم بان بخ برس بسبب بس بشكل بضع بطان بعد بعض بك بكم بكما بكن بل بلى بما بماذا بمن بن بنا به بها بي بيد بين بس بله بئس تان تانك تبدل تجاه تحول تلقاء تلك تلكم تلكما تم تينك تين ته تي ثلاثة ثم ثم ثمة ثم جعل جلل جميع جير حار حاشا حاليا حاي حتى حرى حسب حم حوالى حول حيث حيثما حين حي حبذا حتى حذار خلا خلال دون دونك ذا ذات ذاك ذانك ذان ذلك ذلكم ذلكما ذلكن ذو ذوا ذواتا ذواتي ذيت ذينك ذين ذه ذي راح رجع رويدك ريث رب زيارة سبحان سرعان سنة سنوات سوف سوى ساء ساءما شبه شخصا شرع شتان صار صباح صفر صه صه ضد ضمن طاق طالما طفق طق ظل عاد عام عاما عامة عدا عدة عدد عدم عسى عشر عشرة علق على عليك عليه عليها عل عن عند عندما عوض عين عدس عما غدا غير  ف فان فلان فو فى في فيم فيما فيه فيها قال قام قبل قد قط قلما قوة كانما كاين كاي كاين كاد كان كانت كذا كذلك كرب كل كلا كلاهما كلتا كلم كليكما كليهما كلما كلا كم كما كي كيت كيف كيفما كان كخ لئن لا لات لاسيما لدن لدى لعمر لقاء لك لكم لكما لكن لكنما لكي لكيلا للامم لم لما لما لن لنا له لها لو لوكالة لولا لوما لي لست لست لستم لستما لستن لست لسن لعل لكن ليت ليس ليسا ليستا ليست ليسوا لسنا ما ماانفك مابرح مادام ماذا مازال مافتئ مايو متى مثل مذ مساء مع معاذ مقابل مكانكم مكانكما مكانكن مكانك مليار مليون مما ممن من منذ منها مه مهما من من نحن نحو نعم نفس نفسه نهاية نخ نعما نعم ها هاؤم هاك هاهنا هب هذا هذه هكذا هل هلم هلا هم هما هن هنا هناك هنالك هو هي هيا هيت هيا هؤلاء هاتان هاتين هاته هاتي هج هذا هذان هذين هذه هذي هيهات وا واحد واضاف واضافت واكد وان واها واوضح وراءك وفي وقال وقالت وقد وقف وكان وكانت ولا ولم ومن وهو وهي ويكان وي وشكان يكون يمكن يوم ايان";

		public const string Danish = Latin;
		public const string Dutch = Latin;
		public const string Spanish = Latin;
		public const string Finnish = Latin;
		public const string French = Latin;
		public const string German = Latin;
		public const string Hungarian = Latin;
		public const string Italian = Latin;
		public const string Japanese = "一二三四五六七八九十百千万億兆一-龠々〆ヵヶぁ-んァ-ヴーｱ-ﾝﾞa-zA-Zａ-ｚＡ-Ｚ0-9０-９";
		public const string Norwegian = Latin;
		public const string Portuguese = Latin;
		public const string Romanian = Latin;
		public const string Russian = "\u0400-\u0484\u0487-\u052F\u1D2B\u1D78\u2DE0-\u2DFF\uA640-\uA69F\uFE2E\uFE2F";
		public const string Swedish = Latin;
		public const string Thai = "[\u0e00-\u0e7f]";
		public const string Turkish = Latin;

		public const string Vietnamese =
			"[A-Za-z\u0300\u0350\u0301\u0351\u0309\u0323\u0303\u0343\u00C2\u00E2\u00CA\u00EA\u00D4\u00F4\u0102-\u0103\u0110-\u0111\u01A0-\u01A1\u01AF-\u01B0]";

		private const string Latin =
			"A-Za-z\xAA\xBA\xC0-\xD6\xD8-\xF6\xF8-\u02B8\u02E0-\u02E4\u1D00-\u1D25\u1D2C-\u1D5C\u1D62-\u1D65\u1D6B-\u1D77\u1D79-\u1DBE\u1E00-\u1EFF\u2071\u207F\u2090-\u209C\u212A\u212B\u2132\u214E\u2160-\u2188\u2C60-\u2C7F\uA722-\uA787\uA78B-\uA7AD\uA7B0-\uA7B7\uA7F7-\uA7FF\uAB30-\uAB5A\uAB5C-\uAB64\uFB00-\uFB06\uFF21-\uFF3A\uFF41-\uFF5A";
	}
}