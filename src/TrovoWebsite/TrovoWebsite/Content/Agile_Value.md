# Valuable Agility

![Article Mind Map](./images/Agile_Value.png)

## TLDR of the whole series

This is the third essay of the original series:

1. [The first part](Agile_WhatsThePoint.md) highlights the difference between capital-A-Agile and small-a-agility: a concept ~~stolen~~ [borrowed from Dave Thomas](https://youtu.be/a-BOSpxYJ9M?si=m5g_B7sa9_wK06cp). It also answers the question: "...does anyone remember what the original intent behind promoting agility in software engineering was?" ...with a resounding "NO!".
2. [The second part](Agile_AntiPatterns.md) has a lot of snarky fun pointing out everything that everyone's doing wrong. It bemoans the fact that agility is supposed to be about delivering *value*, above all else. And hardly anyone knows what that's supposed to mean - including quite a few people that society has decreed "incredibly successful".
3. This third and final part is where I finally roll up my sleeves and review some better ways of approaching agility with value at its core. But if I went into real detail we'd be here all month; therefore this essay forms the basis of a curriculum for aligning agility with value delivery in the Digital Realm.

Throughout all three essays I use the phrase "Digital Realm" a lot. The [first article](Agile_WhatsThePoint.md) describes it fully, but a quick definition is: "... the place of frictionless, infinite possibility afforded by working with digital technology". Working here is usually very dangerous and most-often goes horribly wrong, but if you get *good* at working here it starts to offer some serious advantages over working in Real World ways.

## TLDR of this article

The fundamental concept of *value* underpins this essay: a word that's prominent in the Manifesto for Agile Software Development, without *actually getting defined anywhere*. Handy, eh? So this whole essay is about defining value. 

It's a weird concept, because at its core it's subjective: something has to be valuable *to someone* (or preferably, lots of someones, or maybe just a few incredibly rich someones)... But (as the previous sentence hinted), unlike most subjective things, it's also inherently *measurable*. There's an SI Unit of value: pounds, shillings and pence. Ok - the *SI Unit* is probably USDs at time of writing, though it could perhaps become the Yuan at any moment.

As befits such a slippery concept, there are more than a few angles to approach from, but as I've been banging on about "agility" for two previous essays, let's approach it from an "Agile Manifesto" direction. There are three of the 12 principles of agility that are hard to get a grip on without thinking about value:

* **Our highest priority is to satisfy the customer through early and continuous delivery of valuable software.** This is the most obvious as it actually has the word "valuable" in it. OK, so perhaps two decades of wailing and teeth-gnashing would have been avoided if they'd actually defined "value" in The Manifesto, but like I say, it's a slippery concept.
* **Business people and developers must work together daily throughout the project.** This is perhaps the *hardest* one to get any traction on, as "business people" all tend to have day jobs and can't spend all their time cavorting with software engineers. Indeed, it's fair to say that the whole "Product Owner" concept is a method of dealing with this situation. However, Product people becoming "the voice of the customer" is not just plain risky, it's perhaps *the biggest mistake in the whole of software engineering*, unless it's handled *extremely carefully*. How to do so is a big part of this essay.
* **Simplicity--the art of maximizing the amount of work not done--is essential.** As I mentioned in [essay 2](./Agile_AntiPatterns.md), small-a-agility software engineering generates *a lot* of work - automated tests all over the place, endless build pipelines etc - so *you have to make sure the bit that actually gets delivered is valuable*. It's all jolly counter-intuitive if you're not technical.

WRT the second one above: as it's spawned a lot of work for "Product" people, it'll help if we define what a "Product" actually is. If we cheat a bit, it's actually quite easy:

* *A "Product" is a system for delivering value to customers.*

See, nice and simple, as long as we know what *value* is. Read on, Macduff.

Ooh while I'm here, I'd also better include this extra principle, just for luck:

* **The best architectures, requirements, and designs emerge from self-organizing teams.** OK it doesn't mention value anywhere, but if you want to *deliver* value, it's a good idea to encourage teams to "self-organise" around the value you'd like them to deliver; ergo the Products you would like them to build and maintain. At which point, you have to encourage them to discover that value for themselves.

If you've been brave and read the other two essays, you'll probably be amazed at just how massive a hypocrite I'm being at this point, because *I've focused on four of the 12 principles*, at the expense of the other eight... 

I've done very little else up to now other than bang on about how **you have to do all 12 things**. So please take note, if you only focus on these four and don't do the others, **you will fail**. And not in the good "it's OK because we've learned" way - I mean fail in the "lose all the money and end up out of a job" way.

There are lots of moving parts to the concept of value, and it can be sliced and diced in a lot of ways. I've not actually *invented* any of this myself, though, of course. So in the whistle-stop tour of value that follows, there will also be a dramatis personae of the key people I've cribbed from, and the sources they've provided.

## Product Discovery

This is the overarching (or is it underpinning?) concept of value delivery that pulls everything together. The key Product Discovery dude is Marty Cagan, who has done as good a job as anyone of trying to pin down what *value* means. Marty is a Digital Realm guy, starting off at Hewlett Packard and then really earning his chops at Ebay, so his approaches properly address all the "infinite possibilities making life a nightmare if you're not careful" stuff.

So as this is the overpinning concept, we'll introduce some core bits now that'll get referred back to throughout the rest of the essay.

### The three linked concepts that define value

Marty suggests that "value" has three moving parts:

* **Feasibility** - the technical possibility of delivering a solution in a realistic time-frame, and defining the delivery costs.
* **Usability** - whether the intended users are able to understand the product and use it easily-enough to solve their problems. This also gets styled as "desirability", too, as like it or not, there's an emotional aspect to people's decisions to use a product, though this *always* gets outweighed by how well the product eases their struggles, eventually.
* **Viability** - how well the product aligns itself with the business that's delivering it. The obvious key one of these is "how much profit is there in it?", but there are other factors, too (e.g. "is the product actually *legal*, or will company Directors end up in court if we sell it?").

None of these deliver value on their own; indeed it's more the case that each of them can *block* the delivery of value if not properly attended to. To that end, they match with three core roles:

* **Software Engineers** are responsible for Feasibility and own all the "how do we deliver it?"... bits.
* **Product Designers** own all the "can our customers and / or end-users work out what it does? And does it rock their world to the necessary degree?... bits.
* **Product Managers** own all the "does it align with the business? Is it a good strategic play? Will it deliver the outcomes our leadership want? Or will it put them in court / jail?"... type questions. (Note, the answer to the latter question should *usually* be 'no' if possible).

Bring these three dudettes together and answer all these questions properly, and you'll tilt the odds of delivering something valuable from 1 in 10 to about 1 in 3 or better.

### The Business Model Canvas

Key to managing all the above in a lightweight and small-a-agile way is the Business Model Canvas, an approach invented by Alex Osterwalder and packaged up by his consultancy firm Strategyzer. I first stumbled upon this after completing a two-year research project at Cambridge University, where one of the key deliverables was an enormous and unwieldy Business Case that took about six-months to write.

Cambridge is an 800-year-old institution, so six months to deliver one document *is* agile, in that world. But pretty much everywhere else (apart from Oxford), it's not.

However, a lovely chap called [Chris Macleod](https://www.linkedin.com/in/cmacl/) had the patience to explain Business Modelling to me, at least. Which for the software engineer I was at that stage was a bit of a revelation. As a dyed-in-the-wool *small-a-agile* software engineer, I was really in the market for something, you know, quicker, though.

So that's where the Business Model Canvas comes in. It lets you discover your product *quickly*, and fundamentally acknowledges that you're almost certainly going to have to change it, a lot, before it takes off. So rather than the six months it took to write our Business Case (or more accurately, *pickle it*), we could have been acknowledging and testing core assumptions about the market, customers, value propositions, technical activities, partners, costs and benefits within a couple of hours of starting, and then we could have reacted to this information as we went along.

I've heard people say that "the Business Model Canvas is really for start-ups". Well, yes, it certainly would help if you're starting from scratch, but if you haven't got a proper Business Model in place for your product then, if you *are* making money with it, it's probably by accident. So at that point, do a canvas, eh? (More about that later on).

### Deliver Value Not Features

There's been a realisation over the last 15 years or so that if you only focus on the Agile Principles that relate to software quality and delivery, you'll end up with tightly-run, well-drilled engineering machine that delivers easily maintainable, relatively bug-free software to a regular and predictable schedule. Efficient though this process will be, it'll cost a lot.

Even worse, though, there's a strong likelihood (10-1 on) that it'll deliver useless crap that nobody wants or uses.

So [do all the things](./Agile_WhatsThePoint.md).

I have lived this life as a software engineer, usually in response to customers who absolutely, definitely need some chocolate teapot or other. If there's one reason I switched to Product Management, it's that I didn't want to waste any more of my precious time delivering crap people were so sure they wanted, until they weren't.

So here's another fundamental of Marty Cagan's approach - stop delivering "stuff" and start delivering *measurable benefits* to your customers. *Value*, in another word. It's not as if Marty invented this concept, of course, but in all the (software engineer-led) kerfuffle of Capital-A-Agile taking over the world, we'd kind of lost sight of it. He helped bring our attention back to it.

If the main goal you set your team is "deliver me the thing" then (if you've hired a good one), they'll pull out all the stops to deliver that thing, and gladly receive some nice pats on the head for doing so. Even if / when it becomes obvious after about a third of the way through that the thing isn't going to have the impact people wanted it to have. It's what you said you wanted, so here it is. Now you're the idiot for not wanting it any more, and we're definitely not idiots, even though we just went ahead and built the thing you said you wanted, without finding out what your actual problems were.

### Products Not Projects

Related to the concept of delivering value rather than "stuff" is the idea that work should be focused on Products - you know: "systems for delivering value to customers". Rather than "Projects", which are about delivering *things*.

Imagine if you will that the "thing" your team built did actually deliver *some* impact. OK, if they've just ploughed ahead and delivered the thing your project dictated was the end goal, without actually checking that it was going to work as they went, then it would be unlikely to have *all* the impact you were hoping for, but it'll probably have *some*. But you've got to the end of your *project* now, so tough. You'll have to leave all the rest of the value that you *could* capture on the table. Sorry.

Or you could align the team with a *product*, and give them the chance to explore the value it has in the market, to its customers. And let them hone its value-delivery potential. Let them build up a bit of empathy with the customers and users, and really get under the skin of their troubles and tribulations.

That might be a better idea, mightn't it?

### Key Product Discovery people and texts

**Marty Cagan and the Silicon Valley Group** published the go-to text about Product Discovery: [Inspired: How to Create Tech Products Customers Love](https://www.svpg.com/books/inspired-how-to-create-tech-products-customers-love-2nd-edition/). Definitely start there.

Also fundamental to Product Discovery are **Strategyzer and Alex Osterwalder**, who literally wrote the book on the [Business Model Canvas](https://www.strategyzer.com/library/business-model-generation). They in turn have a deep and meaningful relationship with **Steve Blank**, who with Bob Dorf wrote the [most in-depth book about how to use it](https://steveblank.com/startup-owners-manual-1in/).

An alternate, slightly more "corporate C-Suite friendly" perspective that's aligned with the Digital Realm is provided by [Edge: Value-driven digital transformation](https://www.thoughtworks.com/en-gb/insights/books/edge), from (original Manifesto signatory) **Jim Highsmith, Linda Luu and David Robinson**.

And then for a completely different but certainly knowledgeable and accessible perspective, I'd heartily recommend [Learning to Build](https://therewiredgroup.com/learn/learning-to-build/) by **Bob Moesta**. This isn't restricted to the Digital Realm, as Bob's built all sorts of real-world products in his time, but it still applies. And one of his related books about Customer Discovery will feature heavily later.

## Product / Market Fit

The concept of Product / Market Fit encapsulates the small-a-agile *startup's* equivalent of the Holy Grail - the point at which your Product has landed successfully upon an eager (and large-enough) cohort of users and customers.

The value of using your Product is obvious to all and sundry. Growth is unstoppable and organic - the thing just sells itself. Once you find that fit, you can pull money down from the proverbial magic tree.

Oh and with any luck it'll actually make more money than it costs, too. Are you reading, Mr. Altman? But I'm jumping ahead to  Cost / Benefit stuff that comes later. Let's focus on the "delighting the customer" bit first, shall we? Or at the very least: "easing their struggles".

Because if your product doesn't do that, as a bare minimum, and at least a little bit better than all the others that are trying, it doesn't matter how snazzy the logo is, or how quickly each page loads, it'll die.

### Desirability and the top-left-hand side of the Business Model Canvas

Product / Market Fit lives in the top-left-hand-side of your Business Model Canvas, concerned as it is with:

* **The Customer Segment(s) you're aiming your product at:** the more focused the better, not so much because you want to *exclude* types of customer, more that if you try to be all things to all people you'll end up being nothing to everybody.
* **Customer Relationships:** how are you going to slide into people's lives? Are they just going to drop by occasionally when it's purely convenient, for example? Or maybe they'll establish a deep and meaningful rapport with your product and company, and never leave you be? So many choices here.
* **Channels:** as products are a "delivery system for value", just how exactly is that value going to get delivered? Through the customers' smartphones, noisily, on a bus, during rush-hour, perhaps? Or maybe just in a big old cardboard box?

We're firmly in the area of "Desirability" and the Product Designer when we're up in this corner, too, though remember, dimensions such as Usability / Desirability are as much about *removing barriers to value delivery* as they are defining the core value in the first place.

Defining the actual value is the bit you address in the middle box (Value Propositions), which of course overlaps with all this Product / Market fit malarkey, but which is really addressed in the next section on  Customer Discovery.

### Piling in features is not (usually) the right answer

One common anti-pattern is to jump upon all engagement as a clear signal that "if we give (this) customer(s) exactly what they ask for, *everyone* will love it". This is rarely true - remember nine out of ten "good ideas" at best make no difference, and this applies just as much to the ideas that customers bring you as the ones you dream up yourself.

Understand your customer relationships. Focus on their struggles and their pains (more later). Don't try and catch more market share by *doing more things*, unless you're sure that the "more things" you're doing have got a great chance of taking even more pain away for a key market segment.

So take all such engagement as an opportunity to do more Customer Discovery (see below), but don't start implementing anything until you've got to the bottom of why the customer is asking and done plenty of testing within their segment to find out if they share their pain with others.

### Is Product / Market Fit just a "startup thing"?

I'd say that, in the Digital Realm in particular, where everything's all slippery and never stops changing, *keeping* good Product / Market fit is as much a thing as finding it in the first place, so I'm going to say "no" to the "but is it just for startups?..." question.

I find it helps to think about the [Kano Model](https://en.wikipedia.org/wiki/Kano_model) here, which is a model of various forms and stages of product quality, and the properties of products that make them desirable. Early-stage products that afford new opportunities to an eager market can be categorised as "delighters" - things that really make customers feel like their struggles are being addressed in amazing new ways.

However, in the Digital Realm, today's "delighter" is tomorrow's "meh". And you're only ever two clever, disruptive nerks away from oblivion in the Digital Realm, too. So resting on ones amazing Product Market Fit is always a mistake, particularly if you're not that sure how you got it in the first place... Lucking out on great Product / Market fit by accident is a phenomenon disruptive, digital products can be especially prone to. 

The software and tech companies with longevity in the Digital Realm have all worked out how to re-invent themselves.

### Key Product / Market Fit people and texts

This is where Bob Moesta's [Demand-Side Sales 101](https://therewiredgroup.com/learn/demand-side-sales-101/) begins to step up - particularly wrt how to break down customer's struggles, and the tactics for positioning your solution correctly at every stage. But there's much more about Bob and this book in the next section on Customer Discovery.

As we're deep into mapping the Business Model Canvas onto all your "Go To Market" work here, this is where it really pays to have a copy of [The Startup Owner's Manual](https://steveblank.com/startup-owners-manual-1in/) to refer to as you go along.

Martina Lauchencgo's [Loved](https://www.svpg.com/books/loved-how-to-rethink-marketing-for-tech-products/) is from Marty Cagan's stable, the Silicon Valley Group, and thus focusses upon products in the Digital Realm. Loved is strong on how to align products with sales and marketing, at its heart from the same position of "delivering value not features" as underpins everything I'm on about here.

Marc Andreessen’s [original blog post about Product / Market Fit](https://pmarchive.com/guide_to_startups_part4.html) is a good precis of all this, though perhaps only for the memorable, accurate and yet disturbingly icky phrase: "... the market *pulls* product out of the start-up". Ouch. Though he also gives due props to Andy Rachleff, who came up with the term "Product Market Fit" in the first place.

I suppose I'd better mention Eric Ries's [The Lean Startup](https://www.goodreads.com/book/show/10127019-the-lean-startup) here, too, though I do so somewhat reluctantly because of the benighted term "Minimum Viable Product", which has probably done more to confuse a whole industry than any other. (More in the "Testing Hypotheses" section below).

## Customer Discovery

As discussed in [essay two](Agile_AntiPatterns.md): the biggest, stupidest anti-pattern in the whole of Product is people sitting around pretending they know what their customers / user base are like, or what they do, without ever spending any time at all anywhere near them. This still seems to go on all over the place and it's the absolute dark-heart of everything that's still wrong with the whole IT business. Just **STOP IT**!

Instead, remember this key phrase: "Get Out Of The Building!" Or if you can't get your head around that, the [Pragmatic Institute](https://www.pragmaticinstitute.com/) have a mnemonic for you: NIHITO, or "Nothing Important Happens In The Office". Uncle Marty Cagan also weighs in here, too - you should spend *at least* one hour per week shooting the breeze with at least one customer: buy them a nice big coffee and find out how their week is going.

Indeed - there's a *very specific question* you should ask them...

### Asking the right question

The second-most stupid anti-pattern is *asking people the wrong question* if / when you do go to see them. And that wrong question is: *"...what do you want?"*

This question is a lot worse than useless, because 99 times out of 100 the person you're asking is crazy / misguided enough to think they know the answer. Indeed one of the main reasons people don't actually go out and see customers / users in the wild is because one of them has come into the office with "what they want" on the tip of their tongue. They're desperate to waste your time and money, and their own, too.

Incidentally, the companion *what do you need?* is just as bad: which is a shame, because there's a whole template for documenting Agile User Stories that goes: "as a so and so *I need* a something..." This is for *documenting the solution*, but you should studiously avoid asking people what they think the solution to their problems are, when you haven't asked them about the problem yet.

So what's the correct question? It's:

* **What did you do?**

*Everyone* can tell you *exactly* what they were going through when they suffered the problem you think you might be able to solve. They can tell you in extreme detail, and you should ask for it. Take them back to the last time they experienced the problem, and ask questions that help them replay the experience. Even "what did you have for breakfast that day?" Or "how was the commute that day? Were you on time for work?" Anything to put them back there, and then they can walk you through the whole timeline of **the problem** from start to finish. (Note, said timeline often starts before everyone thinks it did, too, when you get into it).

Just ask the question people can answer easily, and truthfully. And then ask them to replay further scenarios where the problem might have happened slightly differently. And then ask three or four more people. Not only will you then have a good handle on the problem to solve, but you'll have also heard your market describe it *in their words*, too.

### Jobs To Be Done

Another helpful approach is to analyse the *jobs people are trying to do*, or *the struggles they are having*, and not *the people themselves*. Putting people at the middle of the analysis is the more traditional approach from marketing, and is enshrined in things like Personas etc, but it can mask the problem if you're not careful. So put people's jobs, or their *struggles*, front and centre - you'll still learn everything you need to know about the person when you do.

This readjustment has a name: the *Jobs To Be Done* framework (JTBD). There's a lot of overlap between JTBD and Product / Market Fit. Part of JTBD is to think in terms of customers "hiring" or "renting" your product to solve a problem, rather than buying it outright. This really helps in the Digital Realm, where the barriers to competitors building the app that's going to disrupt your long-standing products into oblivion are low. Your current customers are only "hiring" your product for as long as it's the best solution, and when a brighter young thing comes along, they'll fire it. Life can be so cruel.

### The Value Proposition Canvas

Another way of thinking about "struggles" is in terms of "pains", and modelling the problems people have in terms of pain is a core part of The Value Proposition Canvas. This is an addition to the Business Model Canvas, and was designed because, if you're doing it properly, the BMC's middle "value proposition" box can get rather too full.

The Value Proposition Canvas also provides an opportunity to start think about solutions, too. So when you've defined the job your customers are struggling with, and the pains these struggles cause, you're also encouraged to think about new opportunities that might emerge as your solution is applied - i.e. the extra "gains" they might get from your solution that take it above and beyond merely easing their current struggles.

This is all very Digital-Realm-friendly, because it encourages thinking about "new affordances", i.e.: what does this new technology allow the customer to do that they've never been able to do before?

One note of caution, though: "what's your job?"... is another weird, tricky-to-answer question that'll take you all down the wrong path. The Value Proposition Canvas kind of encourages you to ask it, though, if you just take it at face value. Remember,  "tell me what you were doing..." is the trick to unlocking problem scenarios.

### Key people and texts about Customer Discovery

My favourite Customer Discovery person is Bob Moesta, who wrote a great book about it: [Demand Side Sales 101](https://www.demandsidesales.com/). This gets completely under the skin of the "what were you doing?" question, with some brilliant real-world examples of how to use it. Bob also tweaks the idea of "jobs" to the more emotive "struggles". Doing this helps better align Customer Discovery with *Sales* (as per the title); a group of people that are obviously completely crucial to any business, but who can make life utterly miserable for everyone by changing products on the fly to get customers on board. Bob tells the story of when he did that, and why, and how he worked out how not to.

One of Bob's mentors was Clayton Christensen and they worked on the Jobs To Be Done framework together. [More about that here](https://hbr.org/2016/09/know-your-customers-jobs-to-be-done). I believe Clay Christensen also came up with the term "disruption", too, which starts to overlap with the fundamental concept of "affordances", e.g. the (potentially new) opportunities "afforded" by the way people and technology interact. That all comes from Donald Norman's [The Design of Everyday Things](https://en.wikipedia.org/wiki/The_Design_of_Everyday_Things), which in turn gets into [Design Thinking](https://www.designcouncil.org.uk/our-resources/the-double-diamond/), and the concept of getting the problem defined before solving it.

The phrase "Get Out Of The Building" can be attributed to Steve Blank, and his and Bob Dorf's [Startup Owner's Manual](https://steveblank.com/startup-owners-manual-1in/) is particularly strong on this topic. Indeed I believe the phrase "Customer Discovery" itself also comes from Steve Blank. It's worth checking him out [on YouTube](https://www.youtube.com/watch?v=rqYmsrjJH3g&list=PLysM940HUUsAutvEcx9JdcejACk-Ia0b9&index=1) for some good examples of asking the "what were you doing?" question.

As discussed, to capture JTBD information in quick but engaging ways, you can't beat Strategyzer's [Value Proposition Canvas](https://www.strategyzer.com/library/value-proposition-design-2), which goes hand-in-glove with the Business Model Canvas, and hence is key to the whole approach described here. They give due props to Bob Moesta, too. But, somewhat annoyingly to use OCD types who work in computing - they drew it *the opposite way around* to the double diamond, so the problem is on the right, and the solution is on the left! (They have their reasons, you're supposed to work around it clockwise from the jobs on the right and so end with the disruptive new "gain creators" most prominent in the top-right-hand corner).

If you're more on the software engineering side of things, you might like Einar Høst's talk about how not asking the right question [causes Technical Debt to get into products](https://youtu.be/d2Ddo8OV7ig?si=aQmErwkglXuD-Qyx). And it's definitely worth checking out Alberto Brandolini's popular engineering technique of [Event Storming](https://www.eventstorming.com/) too. It doesn't mention "the question" explicitly, but it is all over working through scenarios in a timeline. So same difference, really.

## Value = Benefits MINUS Costs

I mentioned at the start that "value" has this weird property of being both extremely subjective, and also *totally measurable* at the same time. So this is the point where we get into the process of measuring it.

In [essay 1](./Agile_WhatsThePoint.md) I described how my PhD was in part a mini-crusade to find out what "value" actually means, and I concluded (eventually) that it all comes back to money as a method of enabling apples-to-apples comparisons between pieces of work that are inherently different. (Indeed if you believe [The Barter Story / Myth](https://www.cato.org/blog/myth-myth-barter), enshrining comparisons between completely different things into a common structure is what money is actually for).

As one of the fundamentals of small-a-agile software development is to *prioritise delivering the most valuable things*, it seems clear that it's impossible to be agile without some methodical way to compare the values of said things. This is what Business Models enable, so how can you possibly be *agile* without a Business Model of some sort?

The flip side of this (as mentioned earlier) is that Business Models can get *very convoluted, very quickly*, and collapse under their own weight into the realms of "big design up-front". This is avowedly **not agile**, at all, both because it takes a long time, but also because all the effort it took to build your lovely model will get you so invested that you won't want to change it.

If only there was some sort of quick, flexible way to explore Business Models...

### How the Business Model Canvas adds a value dimension to your work

At its heart, the Business Model Canvas is a rapid Cost / Benefit Analysis tool that allows for the sort of flexibility and change afforded by the Digital Realm. The part of the Canvas where costs and benefits are weighed-up is across the bottom of the whole shebang. Your "Revenue Model" sits on the right, and is where you *sum up* the estimated financial value of all the benefits you're going to deliver to your Customer Segments, via your Channels, and using the Relationships you build with your Customers. As it's a Revenue Model, you're also supposed to consider the flow, too - so are you taking money from everyone via a monthly subscription? Or do you want them all to pay for it up front?... Kind of thing.

Sitting in the middle is the "Value Proposition" section, which defines the balance between both halves. You're supposed to create *one Value Proposition Canvas per Customer Segment*, and it's in those where you'll really get under the skin of the problems / struggles you're solving for your customers, the thing(s) you're going to build to provide that solution, and all the sexy new opportunities those things will provide to help customers do stuff they never even realised they were desperate to do.

(Of course, you're also going to test all the assumptions you make when dreaming all of this stuff up, too, about which more below).

Then the right hand side of the Business Model Canvas is where all the costs sit. And because costs tend to be *so poorly handled* in the Digital Realm, I've devoted a whole little subsection to them.

### Uncontrolled costs

I feel a little uncanny at this point, because *surely, in a capitalist society*, everyone should be measuring how much it costs to produce and deliver "things", shouldn't they?

Well, it really doesn't appear like that's the case, from where I'm sitting. Costs that are poorly-managed, indeed completely uncontrolled, seem to be a feature of the tech sector, ranging from companies that just haven't worked out a business model at all, to ones that seem to exist [in order to fleece money from investors](https://wlockett.medium.com/you-have-no-idea-how-screwed-openai-actually-is-8358dccfca1c) (or indeed, entire nations).

Avoiding such traps is what the top-left-hand-side of the Business Model Canvas is for. This is where the software engineer on the team steps up and defines the "Feasibility" parts of your value-delivery scheme:

* **Key Activities:** the main things people are going to *do* in order to deliver your product. This includes "building it", of course, but one oft-made mistake is to *only* focus on the building part, and forget all the other parts of delivery, e.g. customer service and other after-market activities.
* **Key Resources:** not just the people doing the doing, but also the tools they'll use, the buildings they'll be doing it in, the amount of Jeff Bezos's compute power they'll be over-consuming when they write sub-optimal code, etc.
* **Key Partners:** which other organisations are you going to rely upon to do the bits of value delivery you're not so good at, but it's not worth your time to learn, or invest in the infrastructure to deliver yourself?

If you've done much "traditional" Business Modelling then those three categories will probably look quite a lot like lines on your cost sheet. That's because they are. Indeed, on the canvas, everything on the left-hand side should feed down into the "Cost Model" section.

Which leads me to a final point here: much as I would see bits of half-arsed UML Sequence Diagram scribbled on a whiteboard during some technical brainstorm as being "a rapid step towards an architectural design", I also think of the Business Model Canvas as being a lo-fi step towards a "full", "proper" Business Model. Once you've achieved product / market fit for a scalable Business Model, you should really start putting proper, formal bones on *both* your software design *and* your Business Model. If you ever get that far.

### Key people and texts about Business Models

Of course the key tome I use when it comes to Business Modelling is [Business Model Generation](https://www.strategyzer.com/library/business-model-generation), though remember it goes hand-in-glove with [The Startup Owner's Manual](https://steveblank.com/startup-owners-manual-1in/).

However, *the* main pitfall Business Model Generation is that it doesn't make the importance of *running the numbers through your model* clear enough. Indeed you have to wait for Alex Osterwalder to get [twenty-five minutes into this key presentation about it](https://youtu.be/8GIbCg8NpBw?t=1510) before he reveals this vital point. It's a big part of Blank and Dorf's book, but it could really be made more obvious in the original text.

I put this down to the barrier between business people and software engineers that I describe [in the first article](Agile_WhatsThePoint.md). I think it's perhaps just so obvious to business people that a model should be based on numerical estimates that they don't feel they have to labour the point, while us software engineers remain none the wiser. Neither group understands how little the other group knows about what they do, and people with a foot in both camps are rare.

Speaking of numerical estimates, though - I ought to recommend Douglas Hubbard's [How To Measure Anything](https://www.goodreads.com/book/show/444653.How_to_Measure_Anything), as it'll show you how to *really* run the numbers through your model.

And because there's really no Revenue Model that hasn't been thought up before, I'd also suggest saving time by keeping a copy of [The Business Model Navigator](https://businessmodelnavigator.com/about) to hand, too.

## Focusing Effort Upon Value Delivery

The frictionless nature of the Digital Realm means that it's very easy to change direction, which is, of course, why the term "agility" was used to describe it. More often than not, the lack of friction is a curse, because it's very hard to keep focused upon value and how to deliver it. Unless you really understand how to work with digital systems and content, it's far too easy to flip-flop from one "number-one priority" to another, without any *focus* upon delivering value.

However, a small tweak to how work is conceived of and planned can turn the pitfalls of agility into a major advantage. That tweak is to change focus from delivering *outputs* to delivering *outcomes*. Or in other words, focus on delivering the *benefits* of the software you're building, *not the software itself*.

Teams that really get how to work in the Digital Realm understand how to use the lack of friction and the ability to change direction to *pick the approach most likely to deliver the benefit*. Another good way of putting this is to *provide a strategic outcome* that success is measured by, but not prescribe the *tactics* required to achieve that outcome. Then teams can measure the extent to which their tactics might be working, and *change them if they're not* - in ways that are, you know, **agile**.

### No Roadmaps!

One concept that really gets a beating when realigning to focus upon delivering outcomes is Ye-Olde-Roadmap. Marty Cagan in particular *hates product Roadmaps*, because they're inevitably based upon wild-arsed guesswork, but the sense of false certainty they impart nevertheless lines people up towards the wrong answer.

The people in question aren't just the delivery teams, either. The main reason Roadmaps are still such a feature in software engineering are precisely because of the sense of "certainty" they provide the wider organisation. Note: this is just a roundabout way of saying that Roadmaps often get cited by sales and marketing people as a way of getting out of difficult: "... why doesn't the thing you've sold me do the stuff I think I need it to?"... type conversations with customers. "It's on the Roadmap and you'll *definitely* have it by April 1st" gets them out of the room with their softer parts still intact.

Of course, the right answer to the "where's my thing?" question is something like: "... walk me through the last time you thought you needed it" - see Customer Discovery, above. But one piece of key information to take away from the answer should be "which of the customers needles do we need to move, on which dials?" Is it: "too many mistakes?..", for instance? Or maybe: "...not selling enough?" Etc...

### Objectives and Key Results (OKRs)

The most popular framework for defining problems in terms of measurable outcomes is Objectives and Key Results (OKRs), invented by Intel CEO Andy Grove in the 1980s and 90s.

OKRs are a great *theory*, but they're a big cultural shift, so a few ingrained habits need to be broken to implement them. The main place I've worked that tried it didn't really get it: "we're doing OKRs now" was announced with a bit of a fanfare, but before we knew it we'd fallen back into old habits of slogging through set plans and implementing business cases that defined solutions for us to deliver. Old habits are like that.

Such difficulties make sense when you think about it. Software engineering / product delivery teams *exist to build stuff*; they're all about the output. And along with salespeople, they're also happier when there's a bit of certainty, and tend to think that they've failed when work they've invested in isn't having the desired impact, and the time comes to try something else.

One key is to not give people too much time to get invested: more about this below. Though at this point I'd also suggest that another reason for OKRs being a bit difficult is the interchangeability of the words "outcome" and "objective". "Objective" is vaguer - and the complete no-no "deliver an output" can also be an "objective". 

Can't we just change OKRs to mean "outcomes and key results"? But actually, the "Key Results" part refers to the measurable outcomes of meeting your objective... What chance does anybody stand with all these "O" words?

Focus on delivering the benefit, not the thing. That is the be-all and end-all.

### Goals, Ideas, Steps, Tasks

The GIST framework is an approach for dealing with one of the big issues with OKRs: how to turn them into bits of executable work that people can actually do. GIST goes hand-in-glove with methods for testing hypotheses. There's a whole section about this coming next, so we'll just cover the "G" part for now.

According to GIST, how OKRs transfer into work is by organising a hierarchy with a couple of overarching Objectives at the top, based on these Key Results:

1. A "North Star Metric", which is the most-simply expressed (but accurate) measure of the overall value you're delivering to the market ("items consumed" is the example given, for a grocery supermarket).
1. A "Top Business Metric", which is intended to keep all the work everyone does viable and aligned with the business. This is usually something like "increase revenue from £1M to £1.1M" or "increase earnings from 22% to 23%".

Then its up to departments and the teams within them to come up with their own OKRs that align with those two. They can then set  Goals for the team that are based upon those.

Typically, all this should slot into a quarterly cadence, so everyone gives themselves three working months to work out the best ways to move the needles defined by their KRs and achieve good outcomes. At which point, just to keep everyone happy, you can put the planned work on an *Outcome Roadmap*; so the same sort of "this will be done by then" type plan as an Olde-Worlde-Roadmap, but with "this needle will be moved to here by 1st April", not "you will have your flying teapot by then".

The GIST hierarchy then tracks the teams' goals all the way down to sprint's worth of work for people to do. More below in the Hypotheses section.

### Lean Value Trees

On the surface, LVTs seem a very similar concept, as they are also based upon a hierarchy for transforming strategic direction and vision into actually day-jobs for people to do. However, the difference is that the hierarchy is "shifted up" one level - where GIST tracks the process all the way down, LVTs start at the level of "Vision": a "guiding direction towards which all investments should contribute", and goals come in at the next, main branch level.

So LVTs need to be implemented in cahoots with another approach to organising actual work, namely "Measures of Success", which we'll also cover in more detail when we come to the "Testing Hypotheses" bit.

The other thing about LVTs is that they're not explicitly aligned with OKRs. But I'd suggest the concept is a bit stronger than GIST when describing  *what all the levels of middle management are for*, still, once teams are generating all the ideas. The LVT concept has a lot more detail about how to *govern* these team-centric approaches, and how the "upper-echelons" should manage the "visionary" bits at the root of the tree.

Fundamentally, both approaches are about getting strategy into tactics and then on into work, though, which is quite the trick if you can pull it off. Exact levels of success will be completely affected by company culture, though, so it's worth considering both and thinking about which is more likely to fit where you are.

Generally I think I prefer GIST, though, as it fits with things that might already be going on (e.g. Scrum backlogs), so it's easier to introduce by stealth, especially if your organisation thinks that it's doing OKRs already.

### Key people and texts about focus

GIST comes from Itamar Gilad's [Evidence Guided](https://itamargilad.com/book-evidence-guided/), which clearly describes how to line OKRs up with work. It's a cracker - I'd get it if I were you.

There's a lot about Lean Value Trees in [Edge](https://www.thoughtworks.com/en-gb/insights/books/edge) and it's definitely worth diving into them for a comparison with GIST. It's similar, but perhaps more explicitly "big corporation friendly". If you haven't got time for a whole book then a) you should make some, but b) here's a [slide deck about LVTs](https://www.slideshare.net/slideshow/lean-value-tree-overview-82783795/82783795) instead, though you might need to read 12 books about Lean first before you can understand it.

Christina Wodtke's [Radical Focus](https://www.goodreads.com/book/show/28951428-radical-focus) is a good introduction to OKRs and it's the book that really explained the "let people change their tactics" bit to me. However, if (like me) you also enjoy a bit of schadenfreude then Kevin Mackie's Medium Article provides many ways [to do OKRs wrong](https://medium.com/@kmackie4/why-most-okrs-fail-and-the-fix-that-actually-works-47c500c91a6f), most of which are addressed by GIST and / or LVTs.

## Testing Value Hypotheses

So at long last, we reach the big payoff: the point at which being small-a-agile, i.e. bringing all 12 of the angry snakes together in perfect balance, starts to provide people that are building software with distinct advantages over those that are merely making stuff up as they go along.

That said, what I'm about to describe could be described as "making stuff up as you go along". The difference is that doing it properly means "making stuff *methodically* and *scientifically*". This means, *experimenting*, *measuring the outcomes* of the experiments we conduct, with measurements defined in terms of value delivered. We started to introduce this in the previous section with the discussion of outcomes over outputs and key results. This is where we explore the practical application of this.

There's a major caveat here: to experiment properly you *have to be good at experimenting*. I.e.: you should have at least an affinity with scientific methods. It's quite easy to conduct "experiments" that simply exist to confirm your biases, so an inability to at least try and remain objective about results, and failure to acknowledge that experiments that turn out exactly as expected are as rare as hens' teeth, put all the good intentions behind experimentation at risk.

Never forget: a *successful* experiment is one that turns out unexpectedly, because it teaches you something you didn't know about the value of your product, and hence either increases the chances of its success, or strengthens the case that you should stop throwing time and effort at it for no return. Either way, you'll end up richer.

### The Dreaded MVP

The idea that software engineering teams should experiment with value isn't new. Unfortunately, though, historically it's been tied to a concept that's a strong contender for the most confusing and misunderstood in the whole Digital Realm: the *Minimum Viable Product*.

I've lost count of how many meetings I've been in where some garbled, confused interpretation of "MVP" has been tossed across the table. What it's supposed to mean is "do the least amount of work possible to get your business idea into the market, get some feedback and test your wobbliest assumptions". So the "minimum" part is OK. It's the other two words that twist everyone's head.

One big issue is that the word "viable" really confuses and stresses-out software engineers. In their world, this immediately translates into "not going to get hacked", and "able to scale to the five million concurrent customers we're going to need to pay for the 18 bedroom mansion in the Cotswolds that it is my destiny to own".

The word "product" similarly confuses people on the business side, who tend to interpret it not so much as "a system for delivering *value to* customers" as "a system for *extracting payment from* customers".

If these sorts of definitions are in people's heads, then *the word "minimal" no longer applies*. What you're thinking of is *an actual, box-fresh, fully functional product*. These take *months* or *years* to build, and that is, of course, a ridiculous amount of time to be waiting to test assumptions that are almost certainly wrong.

So we've reached a stage where so many people have misinterpreted MVP and made a ruck of them that it's best not to mention them at all. Instead, encourage software engineers to focus on *feasibility*: i.e. "could this design scale"? "How easily hacked might it be"? And of course "how much is it likely to cost"?. Then focus product and product design on the "viability" and "usability / desirability" bits... "Is the target Customer Segment big enough?" "Does the idea land well with them or are they confused by it?" "What kind of service delivery effort would be involved in maintaining the sort of Customer Relationships we're considering?" " And: "will the proposed revenue model generate enough cash flow to keep the whole lot upright?"

Trying to answer these questions will generate whole heaps of *assumptions*, which it then becomes the job of the team to *test*.

### Assumption Mapping

There's a pretty simple technique called Assumption Mapping, which fits in well with the Business Model Canvas. It's pretty much as described above: the team of three amigos uses their canvas to document important decisions and ideas about the key parts of the canvas, but they also slap notes about the assumptions they're making around the edge of the canvas.

A core example of an assumption related to a value proposition would be: "customers in segment y experience pains and struggles that will make them desire this flying teapot", though there would also be ones such as "there are enough customers in that segment in the first place", "we'll be able to find the kind of partners we need to help us deliver the product at this sort of cost", etc.

Then the Assumption Map is the standard 2 x 2 matrix that pops up everywhere - with "how much evidence do we have?" along the X axis (from high to low), and "how important they are" on the Y, from low to high bottom to top. This results in a top-right-hand quadrant full of the most important assumptions, based on the least amount of evidence, for the team to focus upon.

Perhaps it goes without saying that this is an iterative technique, so as you learn more, you go through the process again, and fresh assumptions should bubble up into the "low evidence / high importance" quadrant. And as it's the Digital Realm and is all slippery, you should never stop until it's time to turn your product off. Assumption Mapping will help you decide when that is, of course.

### GIST and Confidence Levels

Structuring experimentation into actual bits of work for a team to do is the core of the GIST framework introduced in the previous section. The "I" stands for Ideas, which is, of course, something a lot of people have. They're usually not very good, so the key activity is weeding out the bad ones by testing, testing and testing again. Indeed, it's quicker if we think of all early-stage, "bright" ideas as being assumptions.

A key tool for doing this is "the Confidence Meter", which provides a framework for assessing how confident the team are about an idea at any given stage. "Confidence" itself relates to two specific dimensions of a product's development: the Impact we feel it's going to have, and the Ease of delivering it. Which makes a simple if somewhat misleading mnemonic: ICE.

Things which have traditionally provided great degrees of confidence in product ideas, such as "the Highest-Paid Person in the Organisation thinks it's bound to be easy to deliver", or "the sales team keep telling us that it'll *definitely* have huge impact", are given very short shrift on the Confidence Meter, but as merely ignoring such things can be very career-limiting when a competitor makes a glorious success of the Idea in question, they're not entirely off the table.

Instead the trick is for the team to acknowledge such ideas, and then plan in the work to shuffle what we know about the potential Impact and Ease of delivery around the Meter until they're better understood. Doing so will likely confirm that the Idea is not going to fly in its current state (the odds against are alway high), but at least they might generate fresh Ideas to start on anew. But a few Ideas ought to get somewhere, at which point actual products start to emerge from the murk.

Interestingly, the initial launch of a fully-fledged product Idea into the market doesn't correlate to the highest level of confidence, as the Meter acknowledges that there's still lots to learn about the product at this stage. So maximum confidence is only established once the product is going gang-busters in the market and killing all comers stone dead. At this point I'd add: "it's the Digital Realm, assume such a glorious state is only temporary, and keep assessing how confident you are on a regular basis".

### Making "Bets"

Just as GIST has its own model for confidence and uncertainty, so does the Lean Value Trees / Measures of Success (LVT / MoS) approach. This is based upon a "Bets" metaphor.

For my money this is a broken metaphor. People *bet on something* adversarially, when they're presented the odds of something happening and reckon they've been worked out wrong. At this point, they are *certain* that they understand the situation and its probabilities better that the person presenting the odds, and are prepared to risk money on the *fact* the chance is greater than their opponent believes it to be.

So it's got very little to do with hypothesising, which is about learning more about things that are only partially understood. Being humble, in other words, and admitting that you don't know everything. When gambling, both protagonists each think they already know more about a given situation than the other.

That said, there's plenty in the LVT / MoS approach that recommends itself. For instance, there's a template for helping the team structure their tests, along the lines of: "...we believe that by *doing this thing* we will *cause this valuable outcome*. We will validate this idea by *performing this action*." Some teams might like this sort of structure.

Also there's a good model for the types of indicator to measure: high-level concepts at the top of the "goal" hierarchy would typically be measured with "lagging" indicators, i.e. measures where it takes a while to move the needle, whereas the things we believe might cause us to reach a goal can be measured with leading ones, i.e. more immediately-measurable ones such as "how many widgets did we sell on Tuesday?" or "what's the average length to time it takes a customer to install this gizmo?"

### A/B Testing is *the* Digital Realm technique

Tying this all back into small-a-agility, we quickly reach the conclusion that the slippery old Digital Realm, where we need to move in baby steps to be sure we're moving forward on a firm footing, lends itself to a fundamental form of incremental "A / B" testing. Basically, "have the changes we've just made improved things or not?"

This is what a good proportion of the 12 Angry Snakes relate to. Because product in the Digital Realm aren't real, and are essentially flows of data and information that are mediated and abstracted by code, they're just plain fragile and vulnerable to unexpected breakages. Change too much at once at your peril.

Instead, know where your key indicators / needles are, then watch them like a hawk with every change. One common approach is to put the newer version in place alongside the old one, using the users of the old one as a control group to compare against how users of the new one are getting on. This has some scientific merit though I personally find it quite annoying when a product I'm using keeps flip-flopping between old and new versions, so I wouldn't make this the only tool in your box.

### Key people and sources related to testing value hypotheses

[Testing Business Ideas](https://www.strategyzer.com/library/testing-business-ideas-book) is the book about Assumption Mapping, and also lists various experiments you can do to test assumptions about Viability, Feasibility and Desirability / Usability. It's another Strategyzer / Osterwalder one, but this time with David J. Bland, who came up with the Assumption Mapping technique.

[Evidence Guided](https://itamargilad.com/book-evidence-guided/) has the Confidence Meter in it, and explains in detail how to use it to nudge Ideas around the Meter and break your experiments down into Steps and Tasks for teams to actually *do*. I think it's my favourite, really.

[Edge](https://www.thoughtworks.com/en-gb/insights/books/edge) is a good place to go for an in-depth discussion of LVT / MoS. As I say, I'm not on board with the core metaphor but it's still got some good ideas in it.

Also, highly-recommended to those teams that would like to put rocket-fuel in their experimentation, and get *loads of it done in a week*, is [Sprint](https://www.thesprintbook.com/), which was a technique invented at Google (which is where Itamar Gilad earned his chops, too).

Bob Moesta's [Learning To Build](https://www.learningtobuildbook.com/) describes an interesting approach to uncertainty in product development that he calls "Prototyping to Learn". This is a technique for exploring the whole solution space quickly and efficiently, rather than working incrementally . I'd certainly recommend checking it out, though remember that Bob hasn't just worked in the Digital Realm, so his book contains a real-world example of the process. Bob *dislikes A/B testing*, which he considers a very inefficient way of exploring a problem space. In the real world, he's right, but the real-world lends itself to models that are easier to define, constrained as they are by the laws of physics etc. "Prototyping To Learn" lives in this world, where we need to optimise a constrained model. 

But in the Digital Realm, we don't really know *whether we've got the right model*, at least until we've reached a pretty high confidence level. Also, if the team is genuinely attending to all 12 of the small-a-agility snakes, we can iterate *very quickly*.

## Team Autonomy

As far as software engineering goes, if you're hiring people who *can even cope with* being micro-managed, then your hiring policy is off. Or, as per the quote from Steve Jobs in [essay 2](./Agile_AntiPatterns.md) - who on earth hires clever people and then orders them about?

On the flip-side, running around looking for "10x" people is the wrong answer, too, as there's a good chance you'll end up working with a load of demented extroverts who are merely convinced they're 10x. These are *the least likely kind of people* to produce anything good.

So the trick is to give "ordinary" people the space to become "10x". Or, in a nutshell - there are no "ordinary people" - everyone's got "it" if you give them the space to let it come out.

### Align Teams With The Value They Deliver

In [essay 2](./Agile_AntiPatterns.md) I expressed dissatisfaction with Domain-Driven Design as a candidate for enabling teams to stop treading on each-other's toes and blocking each other. A more effective approach to team autonomy, at least if you understand your business model and know your customers thoroughly, is to align the teams up with the value they're delivering, and not DDD's "sub-domains", which can be hard to define.

It's pretty simple, really - so simple that it was quite hard for everyone to spot for 15 years. You can't "deliver *valuable* software (as per Manifesto Principle No. 1) unless you have *customers*. Software has to be valuable *to someone*. So you can't *ever* be small-a-agile *if you don't have a customer*. Organise your "domains" around value delivered, even if it's to "internal customers" (i.e. "colleagues"), and you at least have a chance of getting some sort of agility together. 

This is easier if you just call your "domains" *products*, because the easiest way to define a "product" is *something with a customer*, that's *a mechanism for delivering value to them*. So to tie all this in with concepts introduced earlier, I'd suggest that each team should have at least one Business Model Canvas, and related set of Value Propositions that they own and maintain.

### Types of Team

There are plenty of theories and an awful lot's been written about types of software engineering team and how to organise them. They all seem to settle upon the distinction between:

* Teams that face customers and deliver the actual value that exists in the market and hence pays the bills.
* Teams that deliver value to internal customers, either by owning shared pieces of platform, or by understanding particularly complicated, gribbly bits of the software estate (embedded systems are a good candidate - they can get quite weird).

It's worth diving quite deep into all this stuff for some good ideas, but I'd add the strong caveat that *exactly how to organise teams* is extremely company-specific; it's strongly-linked to corporate culture. So there are hierarchical models, if you're a bit top-down, or flatter ones. But they all seem to have the "internal or external-facing" categorisation going on.

### Team Self-Sufficiency

To be honest, you're not going to get too far with team autonomy unless the software engineers you're working with really get how to design digital systems properly. They also need to be able to write code that's easy to change without causing a heap of obscure side-effects that ruin everyone else's day.

I moaned at length about how hard good software engineers are to find in [the second essay](./Agile_AntiPatterns.md), as I think the emphasis on what makes a "good" software engineer has shifted into the wrong spaces.

I may have mentioned that to be small-a-agile requires "doing all the things" a few times. Team self-sufficiency is another place where the importance of that is evident. The issue here hangs on this one of the [12 Angry Snakes](https://agilemanifesto.org/principles.html):

* Continuous attention to technical excellence and good design enhances agility.

A genuinely autonomous team makes their software *easy and quick to change* without breaking everything else around it. Key to this are five interlinked concepts that, really, not enough software engineers know enough about:

1. Modularity.
2. Cohesion.
3. Separation of concerns.
4. Encapsulation (or "information hiding").
5. Loose coupling.

These are five little angry snakelets that have hatched from the original 12, and if you're working with an engineering team that understands them, and (please dear lord) *architects* that understand them, there *might* be a cat-in-hell's chance that you'll get good software delivered quickly.

### Collaboration

So here's the bad news - complete autonomy is a pipe-dream, really. Even if you've got your teams nicely aligned with the value they're delivering, and they've properly-isolated the work they do, and the data they manage, etc, they're still going to need to orchestrate their work and collaborate.

So we need to refer back to goal-setting and leadership at this point. Autonomy is key to productivity, but autonomy without a shared sense of purpose and direction is chaos, basically.

If you're "doing OKRs" (or similar) effectively, the head honchos should have clearly-articulated the top level objectives for *the whole organisation*, and lined everybody up to focus on them. This is what then allows teams to collaborate better - if we *all* know that the focus of our work for the next year is to increase company earnings from 22% to 27%, then that's the lever we can pull when we need the team who's products we depend upon to schedule the changes we need them to make.

And if the team we depend upon thinks of us as *their customers* then it all just helps.

### Key people and texts about autonomy and empowerment

I really think the most important point about team autonomy is good software design and production. This makes Dave Farley's [Modern Software Engineering](https://learning.oreilly.com/library/view/modern-software-engineering/9780137314942/) a must-read. Even if you're not a coder, the first few chapters are worth diving into, because they explain the problems that small-a-agility was intended to address, and make a good case for quality incremental design. And it's not too technical, at all.

In contrast, our Marty Cagan wisely points out that Product peeps really should try and learn how to code, at least a bit, too. Plus he also wrote a really good book about the whole subject of team autonomy and empowerment, too. It's called, er: [Empowered](https://www.svpg.com/books/empowered-ordinary-people-extraordinary-products/). It's key to getting a rounded understanding of the "alignment with value" bits.

Empowered also cites Matthew Skelton's and Manuel Pais's [Team Topologies](https://teamtopologies.com/), heavily. Team Topologies is really the canonical text about autonomous teams, so it's definitely worth a read, despite being slightly too skewed towards the engineering side of the triangle for my liking. It's more aligned with the slightly nebulous concept of Domains and DDD than with value, so I'd suggest it's important to consider Marty Cagan's adjustments to it rather than just read it in isolation.

And I would also recommend turning to Highsmith et al's [Edge](https://www.thoughtworks.com/en-gb/insights/books/edge) again as that has several useful chapters about team autonomy, collaboration and governance. It's more at the hierarchical, corporate end of things, though [Evidence Guided](https://itamargilad.com/book-evidence-guided/) has some goods bit about teamwork and collaboration, too, that ought to work nicely in "flatter" organisations. As mentioned, both these texts are heavily into goal setting, and there's a lot of overlap between that and team autonomy.

## Conclusion

So there's a lot of moving parts to properly delivering value in small-a-agile ways, in the Digital Realm, aren't there?

To quote one of my magic old bosses again: "... agility isn't a magic bullet". It's bloody difficult. That's because *delivering good software is bloody difficult*. If is was easy, then (presumably) we'd be surrounded by utterly brilliant software, wouldn't we? Ahem.

So I'm going to end with a few deeper and more meaningful points about weightier topics that underpin those explored above.

### Management vs Leadership

Most of what I've detailed above requires a change it attitude from those "at the top of the tree", from having a managerial mindset to leading. There's a pretty profound difference, and in my experience it even takes a different sort of person to do each thing.

Great managers, in my experience, have a very even temperament. They don't get angry, just disappointed. They meet with triumph and disaster, and treat those two impostors just the same.

Great *leaders* tend to be a bit more dramatic - they fire everyone up. Their purpose is both to line everyone up towards a goal, and pep their staff up to achieve it. But, crucially, they don't *lie*, either. This is a pretty pejorative term, I know, but let's blame the process not the person. Usually when a leader lies, the first person they lie to is themselves. Nevertheless, if the goal is "get us out of the swamp before we drown", great leaders are truthful about it. They're as happy owning the bad as the good, making supporting them much easier.

The sort of autonomy required to make those working in the Digital Realm productive requires *leadership* more than *management*. The whole "Agile is dead" backlash (which is [where we came in](./Agile_WhatsThePoint.md) of course) is a reaction to the latter, and something of a cris-de-coeur for the former. But switching from one mode to the other can be very difficult for business people to do, and that's at the root of a lot of the Agile vs agility angst.

### Finance And The Digital Realm

The impact that the slippery, crazy old Digital Realm has had on the world of finance is one of those things that's *so massive* it's a bit like the sun: it does its mad old thing in the background, and it's generally a good idea not to stare right at it.

But at the risk of burning our eyes / minds out of our heads, here's a few lowlights:

* Wild speculation about the disruptive power of the internet caused one massive financial crash around the turn of the millenium. I remember it fondly: for some reason the bit that sticks most is a failed website called "ClickMango.com" that caused no lesser light that Patsy from Absolutely Fabulous to [lose lots of money](http://news.bbc.co.uk/1/hi/business/858200.stm). (I have no idea why I remember this).
* That knotted bundle of angst was just a pre-cursor to the crisis that happened in 2008. Family of mine lost a house in that one, and have lived in penury since, so I was all up for a bit of what the good people of Iceland did; i.e. they put their greedy spivs in prison. Anyway, the nonsense that caused 2008's crash would have been impossible without being able to [diddle debt into twisted, abstract models with computers](https://en.wikipedia.org/wiki/Collateralized_debt_obligation). Another victory for IT right there.
* Right now it feels like these two were just hors d'oeuvres to the one that's just around the corner, given the crazy behaviour of "tech-bros" in general and [Sam Altman in particular](https://albertoromgar.medium.com/you-have-no-idea-how-screwed-openai-is-9481fe33f1db). To quote Han Solo: "... I've got a very bad feeling about this".

I mean, the Digital Realm has disrupted *everything* - with the invention of the smartphone being a key milestone on the route to driving *everyone* a bit nuts - and I don't think we've quite reached the bottom of the curve, yet, even. But I suspect it's already disrupted what's oft considered to be "capitalism" into *some sort of oblivion*, too.

That said, we're still going to need money, though - as its original purpose was to prevent us all from having to come to market on the same day, and it *is* a great enabler to the process of comparing apples with oranges. Those will still be a thing, even when, one hopes, making a load of abstract wealth by doing utterly pointless bobbins becomes less of one.

### Is The Concept Of Value Changing?

Given the rant in the previous section, I'd say we're close to a big correction in what we consider valuable. 

"The model replacing reality" is one of the big pitfalls what I've described above, which the Business Model Canvas can epitomise. I've obviously led quite a sheltered life away from the hotbeds of the Digital Realm, tapping away at my keyboard and tutting at the insanity of it all. But from my vantage point, it really does feel as if "the game" is to make as much money as possible regardless of adding any actual value. Investing early, then cashing-in ones chips based upon a great-seeming model, and solid forecasts, but *before* the actual return of real profits.

This sort of behaviour makes one some sort of "winner", apparently. Or maybe it's completely nuts, and not sustainable. And when "unsustainable" means: "...comes crashing down in a avalanche of misery sooner rather than later", then there may be troubles ahead.

Perhaps it's just that my YouTube algorithm insists on showing me videos about a pending financial crash, though, of course. Maybe if I'd made other viewing choices, I'd be sat in a comfortable bubble of "AI is blooming marvellous, innit?..." instead...

I think / hope that the clever, younger people of this world are already coming to sensible conclusions about what value *really* means, though, given that they're being excluded from older-people's games, such as "owning property" or "having a stable career". If the sensible ones among them are also including "the pointless accumulation of cash without actually doing anything valuable" in the list of stupid old people's nonsense to avoid doing, then we might have a chance?

Another (thank heavens, final) point: "...is the Digital Realm changing?" I'd suggest that it's certainly got its weird little fingers in more "real-world" things these days, when we consider phenomena like 3D printing, fast-fashion etc. Remember (from [essay 1](./Agile_WhatsThePoint.md)), small-a-agility isn't "to help you change direction", it's to stop you going completely insane *when there's nothing stopping you* from changing direction. And when the digitisation of everything has made it easier to get into that trap in the real world, too, then you'll need the tricks I've described here in your armoury.

So perhaps the future is that we all have more "autonomy" in the real world, too? And that there will be fewer barriers to us using digital technology to help carve out some comfort for ourselves and our neighbours? Hopefully there's something at least vaguely "empowering" in that thought? 

Hey, end on a song.
