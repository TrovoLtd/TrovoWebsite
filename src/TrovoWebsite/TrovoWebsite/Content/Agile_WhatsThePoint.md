# We have forgotten the point of Agile

This is the Mind Map of the "forgotten the point" article.

![Article Mind Map](./images/Agile_ForgettingThePoint_MindMap.png)

## TLDR of the whole series

1. **Have we forgotten the point of "Agile"?** Yes! First and foremost, it was a defensive way of delivering work in a frictionless, unconstrained un-reality of infinite possibilities. Once we remember this, it all makes a lot more sense.
2. **"[Agile" Anti-Patterns](./Agile_AntiPatterns.md):** when software engineers, product people and designers all work at loggerheads to each other, it all goes belly up. And even more so when the ways we strategise and plan *aren't* agile.
3. **[Valuable agility](./Agile_Value.md):** conversely, when software, product and design collaborate properly, it's possible to navigate the Digital Realm* not only safely, but in ways that put you way ahead of the competition.

\* Think of the Digital Realm as being like the Quantum Realm from Ant-Man but with *a lot more meetings*.

## Upon whose bandwagon am I jumping?

Why - Dave Thomas's of course... He famously\* declared "[Agile is dead](https://youtu.be/a-BOSpxYJ9M?si=m5g_B7sa9_wK06cp)" in 2015, and that opened a door that a great many others have jumped through. A large cohort of these folks seem to be computer programmers who don't like meetings (more in the [next one](./Agile_AntiPatterns.md)), but it also stirred up a good few of the other "Agile Manifesto" signatories and fellow travellers.

\* Famously *for a computer programmer* - Dave's not Taylor Swift, exactly. Indeed he's not even Sue Pollard. But his talk has had 1.4 million views.

Dave made an elegant point concerning the difference between:

* **"Small-a-agility":** where agile remains an adjective, i.e. something describing behaviour.
* **"Capital-A-Agile":** which is a noun, i.e. something you can package up into a certified training course and sell to people.

I like this distinction so I'm going to steal it for these essays. I'm also going to refer to the [update he's started giving](https://youtu.be/bEMg9XXIcew?si=WMmJucZFqZma3xt0) to the original talk, too.

## Does *anyone* remember the point?

The OG agilistas Allen Holub and Dave Farley\* [get not quite but near to the point in this podcast](https://youtu.be/hxXmTnb3mFU?t=665) - Dave F talks about small-a-agility "opening up infinite possibilities" as opposed to being "fundamentally constrained" by big-design-up-front. But that's not quite it: it's not the *agility* that opens-up infinite possibilities, and "waterfall approaches" can't and don't ever *actually* constrain you. (Note - Dave hits the nail right on the head in the first chapter or two of his [Modern Software Engineering](https://www.davefarley.net/?p=352) book, which if you haven't read, you must do so NOW).

Working in the Digital Realm *causes* these endless, frictionless possibilities, which no amount of up-front-design can cope with. Designs and concepts in the Digital Realm refuse to remain fixed. Even the clearest design drawing will get diddled with as soon as you try and implement it, and even assuming you get close, it won't be long before you've tweaked the implementation out of step with the design; *because you can*. **There's absolutely nothing stopping you**. Also, the act of coding itself mediates your interpretation, so there will always been at least some variation from the intention.

Small-a-agility was originally conceived as a *defence mechanism to cope with all this*. This is what we have lost sight of, because once you *can* defend yourself against the chaos of infinite possibilities, you also gain loads of advantages from being able to ride it out. People focus on those advantages because it's where the promise of money sits - but understanding how a small-a-agile approach helps with the pitfalls is an easier first step to take.

\* I'll refer to Dave Farley a lot in these articles. Just in case you don't know, Dave co-wrote [Continuous Delivery](https://martinfowler.com/books/continuousDelivery.html); a strong candidate for being **the** Bible of small-a-agile software engineering.

### Agile beginnings

James Shore and Shane Warden include a great potted-history of both Agile and agility in the second edition of [The Art of Agile Development](https://www.jamesshore.com/v2/books/aoad2). They describe a "crisis of software development" in the 1990s, caused by attempts to control every aspect of software production with highly regulated and governed processes. This is the world of the Unified Modelling Language, the Rational Software Development process and "heavyweight", "waterfall" project management methods such as Prince2. It's a world of big-design-up-front and loads of gates that projects have to get through, or around.

Less than one-in-six succeeded, according to the spectacularly-titled "[CHAOS Report](https://www.csus.edu/indiv/v/velianitis/161/chaosreport.pdf)" of 1995. Interestingly, that report begins by contrasting software engineering with bridge-building, though without actually getting to the bottom of it. They cite "we have 3000 years of bridge-building experience" as the main difference, but I'd also suggest "being constrained by the laws of physics and only four dimensions within which to work" as being extra advantages that bridge-builders have over software engineers. Provided, of course, one measures success as per the report: "...having all the features as initially specified", which has a bridge-buildy ring to it, too.

It's much easier to specify a bridge, in other words, and much harder to start building a serious one without a design, budget, team and plan in place. Shore and Warden suggest that it *might be* possible to apply all that up-front planning to software engineering, too, "... if you keep them slim and operate in a well-understood domain". This goes against my personal experience, where "keeping things slim and well-understood" are things that just don't happen, ever.

### Univeral Machines and infinite spaces

I've been extremely lucky to be coached by two different *Software Engineers*\* who really got small-a-agility. One of them told me a story about helping his dad, a Quantity Surveyor in the Real World, select some software to use. After he'd helped pick the best system for his dad to buy, he told him how lucky he was to know, up front, how big a space there would be to build in, and to have the laws of physics constrain everything.

We don't have these luxuries in the Digital Realm - if your client decides that they would like a submarine dock in the basement of the hospital you've spent the last three years building them, and a space-port on the roof, and that they'd like you to put the ceilings in before you've built the walls, then there's no practical reason why you can't. We work with "Universal Turing Machines" in a slippery, frictionless world of (very nearly) pure information and imagination: there are zero physical constraints and an infinite number of dimensions within which to work. Who knew?

First and foremost we have to defend against this, and "you're driving me nuts" doesn't cut it as a defence, unfortunately - they'll just find someone else to burn out instead of you, at least until their money runs out. "You're the boss" and "I was only following orders" can help a certain caste of *Programmer* on the sanity front, but it doesn't cut it for proper engineers, as it'll only ever result in something good by the flukiest of accidents.

\* More Dave Farley here, on [the difference between Programmers, Developers and Engineers](https://www.youtube.com/watch?v=fcjBfSiyI0k&t=2s).

### Lack of friction

So the infinity and lack of friction results in constant uncertainty about what we do. It also means that everything we *do* achieve is much more vulnerable to disruption than Real World endeavours. The Digital Realm has an extremely low barrier to entry - case in point: how two broke students [completely turned the world of travel accommodation upside down](https://knowledge.wharton.upenn.edu/podcast/knowledge-at-wharton-podcast/the-inside-story-behind-the-unlikely-rise-of-airbnb/). You're only ever two clever nerks away from your beautifully-established business having the rug pulled out from underneath it.

If our laurels are in the Digital Realm then we can never rest on them. Even if we are hugely successful, we have to be able to re-invent everything over and over again. Take Microsoft Office as an example of that - it's been rebuilt from the ground up four or five times over the years - the only constant is the brand. The same old boss of mine used to describe this as "re-building the engine of a sports car while it's doing 170 mph in the fast lane".

This is *nearly* impossible - with small-a-agility tipping the balance from "completely" to "nearly".

### "It lets you change direction" misses the point

It's not capital-A-Agile that's "letting you change direction". Working in the Digital Realm *means you are going to change direction* whether you like it or not. There's literally nothing stopping you. I've been in situations during my engineering career where the thing I thought I was working on would change three or four times in a day. I would go into work clear in my head about what I would be working on, and my precious sense of certainty would be nothing but a glorious memory by 9:30am.

Small-a-agility is the only thing that gives us a cat-in-hell's chance of managing our adventures in the Digital Realm. So to paraphrase Churchill: "it's the worse form of planning and management, apart from all the others".

### Manufactured constraints

The defence against frictionless uncertainty is to *manufacture constraints* to work within. The ones that can be made to work are *time* and *money*.

Uncertainty is a given, so if we work in teeny-tiny increments of time, and check where we are at the end of every increment, we're at least only ever uncertain about a few things at a time (only one, preferably), for a short while. Dave Thomas nails this in the [follow-up to his original talk](https://youtu.be/bEMg9XXIcew?si=WMmJucZFqZma3xt0). 

Money (or should I say *value*?) gives us a direction to travel in. Even tiny-little baby steps waste time and effort if you take them in the wrong direction. Dave Thomas is a bit sketchier on this, referring in passing to "your goal" throughout his follow-up, though he does circle round to it during the questions at the end.

**Massive spoiler alert:** the money thing is **much harder to get right**, because it requires business people that understand design and engineering, and engineers and designers who get business. Gulp!

## Why information and knowledge work is so different

### Vagueness and ambiguity

So how about Shore and Warden's "well understood domains"? Well, maybe I've just been unlucky, but in my experience the idea that we can define what the various "domains" that relate to the problems we're solving has never really stood up. And not so much "define them accurately", even - "well enough to make any progress" would do. Ditto other domain-related ideas such as the "bounded-contexts" that surround them, and the "ubiquitous languages" that everyone within them uses, apparently.

You may recognise these concepts as being from Domain Driven Design - which comes with its own [big, blue Bible](https://learning.oreilly.com/library/view/domain-driven-design-tackling/0321125215/). I'm not especially *anti* DDD, but I'd class it as a *nice theory*, along with various other Thoughtworksy concepts that depend upon it such as [Data Mesh](https://learning.oreilly.com/library/view/data-mesh/9781492092384/). It's never survived any attempts at engaging business people anywhere I've ever worked, anyway - I suspect it takes particularly talented, experienced and presumably expensive consultants to get it across, and even then any clarity achieved is likely to be fleeting. Event Storming at least aligns itself with *the right question to ask* (see below and in later articles) but if you're going to take key representatives from each part of a business away from work and make them stick post-it notes on a wall for a whole day (or three) then the results had better be *spectacular*, or at the very least you'd better be as entertaining as [Alberto Brandolini](https://youtu.be/mLXQIYEwK24?si=2ddYKCVe0WmlAR05).

Instead, we usually attempt to solve problems by approaching them via pre-defined "solutions"...: "we need this feature", "the software should do this", etc. If you're into Lean, then you're supposed to ask "why" five times when this happens, but as this is what *extremely annoying four-year-old children do*, I don't recommend it.

Asking "why" over and over about potential solutions is a symptom of a dark truth lurking beneath software production: while everyone may have their smart ideas, you'll *never* get close to a perfect fit between a digital system and reality. And, despite setting out in hope each time, the quest usually gets brain-snappingly, toe-curlingly abstract pretty damn quick, and logic traps start to snap at everyone's sanity. You know this is happening when the business-people / "subject matter experts" in the room  fall silent, and the programmers start trying to one-up each other with technical terms.

When I was working in the Finance Industry (I use the term loosely), I witnessed the 6'3" general manager of a debt collection company (a guy with muscles on his muscles) reduced half to tears by a five-foot-four, stick-thin, seven-stone-soaking-wet computer programmer. "The poor, poor guy", I thought, as Mr. Muscles sobbed: "Why does all this have to be so complicated?" into his hand.

Turns out we were just asking the wrong questions, of course, but more of that later. The core point remains that The Digital Realm never fits smoothly with reality. See [Douglas Hofstadter](https://en.wikipedia.org/wiki/G%C3%B6del,_Escher,_Bach) and [Roger Penrose](https://en.wikipedia.org/wiki/The_Emperor%27s_New_Mind)\* for further details.

\* These two met each other once, apparently. Penrose is on the record that he thought Hofstadter was nuts.

### Your spec will *never* be fixed

If I had a shiny pound coin for every time I've heard someone say: "where's the specification?", "have you captured all the requirements?" or "have you got a picture of what you want?" then, well, I'd have a free holiday at least.

That's not to say *pictures* in particular aren't useful, they really can be (until they get too busy - like [this one](https://framework.scaledagile.com/#largesolution)), but even the clearest picture in the world...:

* Won't stay clear and current for very long - sometimes for less than an hour after any clarity was achieved. 
* Won't transfer exactly to a code implementation - any two programmers *will* interpret it in a **minimum** of two different ways.

The prime value of a great picture is to refocus everyone on the *problem*. If you get a good one then you *will* have to keep shoving it under everyone's noses over and over again, and you *will* have to tweak it each time.

Clarity is fleeting and uncertainty is rife. The best pictures can give a sense of direction, but the only safe things to do are: 

* Not travel too far in *any* direction without checking you're going the right way.
* Make it very easy to go back and not get upset when you have to.

Loads of effort on designs, plans, pictures or story maps that go into explicit detail about stuff you definitely might do ~~in six months~~ ~~three months~~ ~~three weeks~~ next week disinclines everyone from backing up and trying again, so instead we all plough on getting further away from anything good. So yes, design, map, draw - but don't do too much in one go - one or two small pictures at a time, with 12 things or fewer on them. Don't drown them in words, and use them as the prelude to refocus people back on the problem, before *showing them something that might help fix it*.

### Glimpses of good answers are the best you can hope for

You just have to talk to the people with the problem, constantly. And if they stop wanting to talk to you, this is the best smell you'll get that you're getting further away from a helpful solution. But how you talk to them is really important, too. Doing "the waiter thing" by asking "what would madame like today?" is such a dumb question that there's a whole chunk in [the next essay](./Agile_AntiPatterns.md) about it, plus [the third one](./Agile_Value.md) covers what to ask instead.

But even when you ask the right question\*, chances are you'll misinterpet the answer, or the customers won't answer it correctly, or they'll think of an even better answer when they sit bolt upright in bed at 4 o'clock the next morning. So get your response back to them double-quick (i.e.: the changes you've made to their solution, in the couple of days since they elaborated upon the problem, deployed somewhere they can see them and try them out).

\* If you didn't skip ahead - it's "...what did you do?", definitely **not** "...what do you want?".

Everything about small-a-agility is hard, but maintaining customer engagement with your work is the hardest of the lot. The good news is, that if you *can* maintain it, you'll end up with a product that actually gets used, and maybe even loved, by people. Though they won't *thank* you for it, obviously.

## Has Agile *ever* been "done right"?

The answer as far as capital-A-Agile goes is a big fat **no**. And as far as small-a-agility goes, it's *rarely*. This is because it's really bloody hard to do.

This is true about being physically agile, too, of course. Think of really agile people: Simone Biles, say, or Jackie Chan. They didn't get so nimble by doing a two-day certification course and / or just wishing it to happen, they had to work at it, from a very young age, practicing continually and obsessively until it *looks* effortless.

As mentioned, one difference between Biles / Chan and us adventurers in the Digital Realm is that *we* work in infinite spaces with knowledge and information, not in the physical world of balance beams and film sets, so our exercise involves learning obscure theories about abstract concepts, counter-intuitive coding techniques, etc. In the case of small-a-agility, the obscure theories relate to [five vague value statements](https://agilemanifesto.org/) and [12 contradictory principles](https://agilemanifesto.org/principles.html). There's a huge pile of books written about all of this, and you really do need to have more than a superficial understanding of each part of the puzzle. It's a lot of reading and homework.

Another digital difference is that we can do it until we're a lot older because we can sit in chairs most of the time. Eat that, Biles! And we get well paid for this job, don't we? So we should at least be prepared to learn how to do it well. And we all enjoy learning... That's why we got ourselves into interesting careers in the first place, no?

The chewy part is the application of all this theory: the *praxis*, if you will. As I once heard a bloke from CERN say: "In theory, theory and practice are the same, but in practice they're different". That's where all the muscle-memory of the repeated *practice* comes in - you have to take your theoretical knowledge into battle and watch it get a bloody nose, but if you've put in the homework, you'll think of a smart answer each time. Jackie Chan hasn't quite broken every bone in his body but [it's close, apparently](https://www.youtube.com/watch?v=PA21Bok59rQ). They weren't christened "Coding Dojos" for nothing.

Once you gain a few warts and a bit of career confidence, you learn that you rarely *have* to think of a smart answer on the spot, either. "I have noted your issue and will return with my smart answer as soon as I've had a think" is usually better than trying to wing it when someone important needs your help putting out their latest fire.

### You have to do **ALL** the things

Hopefully you'll have noticed my reference to [The Manifesto for Agile Software Development](https://agilemanifesto.org/) above? Daves Thomas and Farley, and many other OG agilistas, take great pains to refer back to this holy artefact, which like most relics is both deeply instructional and just a little bit on the ambiguous side. One key piece of ambiguity is the instistence that "it's not a methodology", and damn right it isn't. That would be too helpful - but also, bad news alert, the perfect set of rules to follow to produce a killer piece of software every time doesn't exist: it's different every time, and it's *complicated*.

So you're just going to have to suck it up and *learn* what all the bits *really mean*. And I do mean *all the bits*. Despite what many may tell you - *you have to attend to all of it* - all five statements, all 12 principles. Sorry.

Actually I've only just noticed as I write that "agile" has a capital-A in that website's name. Perhaps the last 2.5 decades of misunderstanding comes down to that? Though thinking about it - Dave Thomas makes a very similar point in his original [Agile Is Dead talk](https://youtu.be/a-BOSpxYJ9M?si=m5g_B7sa9_wK06cp).

### But the principles *seem* contradictory?

Well spotted. Keep quality high, but change everything all the time, you say? Deliver software consistently and frequently (with all the added effort of creating build pipelines and managing dependencies), while *also* keeping quality high (test, test and test again), but also while *doing the bare minimum*? Constantly listening to customers' demands, while also designing everything properly (i.e. in ways that seem totally counter-intuitive to them)? Eh?

None of this makes any sense - it's just a mass of conflicting requirements... Isn't it?

### In fact they are checks and balances to each other

Actually, no, it's a matched set of principles that **act as checks and balances to each other**:

* Because nine tenths of your code is written to support getting stuff into production quickly, easily and consistently, you have to make sure the one-tenth you do deploy is focused on *precisely the right thing*, every time.
* Because you may need to change direction at any time to realise the benefits of some great new opportunity as they arise, you need to design your system well, and make sure you can spot the side-effects of any changes before your customers do (preferably, before they get anywhere near your customers). Well-designed software is *easy to change* - how easy exactly is the only valid measure of the quality of it. Knowing how to write easy-to-change software is *the* trick - I've personally messed up a couple of interviews in my time because I talked a good game but didn't *know* [how to do it](https://en.wikipedia.org/wiki/SOLID). I could also point at a fair few very-highly-paid computer programmers who still don't know, too.
* Because you're always *listening* to your customers, you know where the value is. But note, you're always *listening* to your customers, but you're not always *doing what they tell you* - if they really knew what they wanted, why would they need you? The route to value lies in the mastery of the technology, which is why you read all those damn books.

Pull any one of these principles out, and at least one, usually two or three of the others, start going wrong (that's what the [next article](./Agile_AntiPatterns.md), the fun one, is about). The same old boss of mine referred to earlier called this: "The Twelve Angry Snakes"\* - like the repeating Celtic pattern of snakes biting each others' tails. While each has got a grip on another, you're safe, but pull one snake out, the whole thing collapses and you've got 11 angry snakes wrapped around you and biting you in the face.

### There are two fundamentals

Two of the Twelve Snakes are more fundamental than the others, though:

1. Deliver value *constantly*.
2. Get better at doing it (also *constantly*).

Delivering what you're told to is **not it**. Prentending you're getting better because you get together once a week and list all the things you could have done to make things better, then *not actually doing any of those things*, is also **not it**. See [the fun essay](./Agile_AntiPatterns.md) for more of this joy.

The second of these fundamentals is mentioned explicitly in one of the principles: *At regular intervals, the team reflects on how to become more effective, then tunes and adjusts its behaviour accordingly*.

*Delivering value*, however, is *so* fundamentally "the point of small-a-agile" that it's kind of smeared through many of the principles, so much so that it tends to fade into the background a bit. This is *a very bad thing to happen*: indeed I believe this to be even more the root of all trouble as the Agile vs agility thing.

## WTF is "value" exactly?

In 2012 I ~~committed career suicide~~\* paused my industrial career to go and do a PhD. So like all good "doctors"\*\*, I'll take any opportunity to refer to [my own thesis](https://repository.lboro.ac.uk/articles/thesis/Does_the_way_museum_staff_define_inspiration_help_them_work_with_information_from_visitors_Social_Media_/9496598?file=17123216), because let's face it, no other bugger is going to. So brace yourselves, here it comes.

\* I'd recommend doing this at least a couple of times - it's not as painful as it sounds.

\*\* Heaven forbid I ever get confused for a real doctor - though that's highly unlikely.

I spent about three months researching alternative ways of thinking about "value" rather than just counting shekels. I conducted this research in the Museums, Libraries and Archives sector *specifically because* there's (supposedly) less of a focus on cash money in that sector. I did all this just after a decade or more of New Labour pretending (barely / badly) that there might be more to life than money (while also [totally contradicting themselves](https://independentblogposts.wordpress.com/2018/01/21/intensely-relaxed-about-people-getting-filthy-rich/)), and engaging various consultants and spads to find out what such magic ingredients might be.

Obviously there *is* more in this life than filthy lucre, but in a capitalist society, pounds, shillings and pence\* are *the SI unit of value*, to which all endeavours must be converted so we can make apples-to-apples comparisons. After all the reading I did about this, the only paper I can ever recall is [this one](https://ideas.repec.org/p/pra/mprapa/14902.html), which states (and I paraphrase greatly here): "... many people in the cultural sector insist that 'value' isn't all about money, until the yearly budget cycle comes around again, when all of a sudden they can magically put a price on *everything*". To be honest I didn't really learn this lesson properly until the first job I did *after* getting my doctorate, when another patient individual took the time to explain business modelling to me once and for all. This happy tale is told in [essay three](./Agile_Value.md).

\* OK, USDs - at time of writing anyway.

With hindsight, all this research of mine *might* actually have been some sort of quest to find out what "value" *actually is*, because The Manifesto for Agile Software Development **sure as hell doesn't tell you**. Remember, all the signatories to The Manifesto were *software engineers*. Some of them (possibly only one of them - Jim Highsmith - who features prominently in the [third article](./Agile_Value.md)) seemed to realise that, in the Digital Realm, we can't rely upon business people to tell us what "value" is - they don't know and can't work it out without some help.

Many of the other signatories often come across as 'doing the engineer thing' - farming out the responsibility for defining value to business people and trusting them to get it right. I'm afraid this is prime cake-and-eat-it: "... small-a-agility means you *don't get to tell us what to do!*... apart from when working out what to do gets difficult, in which case, please prioritise what the most valuable thing is for us and we'll do that. Though we reserve the right to moan like stink when it turns out you were wrong and nobody uses the thing we built, or loads of people do but the maintenance costs bankrupt the business...". Etc ad nauseum.

I'm afraid Dave Thomas can come across as a prime example of this - see the part about "units of value" in his [second talk](https://youtu.be/bEMg9XXIcew?si=WMmJucZFqZma3xt0) - wtf is a "unit of value" exactly, if not an attempt to abstract the responsibility for finding value away from programmers?

Absolving ourselves of the responsibility for defining value just doesn't cut it - for small-a-agility to work, we all have to be on the same team, and we're *all* on the hook for working out the right things to do, always. Engineers, especially, are on the hook for working out *the costs* of both delivering *and running / maintaining* the software...

... because *Value* = "Benefits **MINUS** Costs", in our Capitalist world. It's what's left over after you've paid Bezos your compute bill, and the first and second-line support crew have claimed overtime for the incident where they all had to get out of bed at 2am because your thing didn't work, and you didn't give them any clues to find out what was wrong with it.

Apples-to-apples comparisons of value are fundamental to small-a-agility - they're the basis of the prioritisation constraint. You can't "do the most valuable thing first" if you don't have a method for *comparing the different values of things*. Spoiler alert for the [third article](./Agile_Value.md) - there's usually only one or two genuinely valuable things to do, anyway - so do those. The rest is probably just bloat on your simple, elegant product.

All software engineers should learn the basics of business modelling. Also (as [Marty Cagan says](https://www.svpg.com/books/inspired-how-to-create-tech-products-customers-love-2nd-edition/)) - all business people should learn how to write some code.

Capital-A-Agile be damned, the biggest cause of "The Death of Agile" is the angry, unyielding wedge that's driven between software engineers and business people. Both sides don't realise how little the other side know about what they do, when there shouldn't even be "sides" in the first place.

* The [next essay](./Agile_AntiPatterns.md) explores the implications of this in more depth. (As I say, it's the fun one).
* The [essay after that](./Agile_Value.md) reviews some of the efforts that have been made to bridge the gap between software engineering and business in the Digital Realm. Skip ahead if you're only here for the answers but you'll miss out on a load of bitter (but entertaining) snark.
