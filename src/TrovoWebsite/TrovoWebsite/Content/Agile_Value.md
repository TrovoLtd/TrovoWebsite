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



## Customer Discovery

As discussed in [essay two](Agile_AntiPatterns.md): the biggest, stupidest anti-pattern in the whole of Product is people sitting around pretending they know what their customers / user base are like, or what they do, without ever spending any time at all anywhere near them. This still seems to go on all over the place and it's the absolute dark-heart of everything that's still wrong with the whole IT business. Just **STOP IT**!

Instead, remember this key phrase: "Get Out Of The Building!" Or if you can't get your head around that, the [Pragmatic Institute](https://www.pragmaticinstitute.com/) have a mnemonic for you: NIHITO, or "Nothing Interesting Happens In The Office". Uncle Marty Cagan also weighs in here, too - you should spend *at least* one hour per week shooting the breeze with at least one customer: buy them a nice big coffee and find out how their week is going.

Indeed - there's a *very specific question* you should ask them...

### Asking the right question

The second-most stupid anti-pattern is *asking people the wrong question* if / when you do go to see them. And that wrong question is: *"...what do you want?"*

This question is a lot worse than useless, because 99 times out of 100 the person you're asking is crazy / misguided enough to think they know the answer. Indeed one of the main reasons people don't actually go out and see customers / users in the wild is because one of them has come into the office with "what they want" on the tip of their tongue. They're desperate to waste your time and money, and their own, too.

Incidentally, the companion *what do you need?* is just as bad: which is a shame, because there's a whole template for documenting Agile User Stories that goes: "as a so and so *I need* a something..." This is for *documenting the solution*, but you should studiously avoid asking people what they think the solution to their problems are, when you haven't asked them about the problem yet.

So what's the correct question? It's:

* **What did you do?**

*Everyone* can tell you *exactly* what they were going through when they suffered the problem you think you might be able to solve. They can tell you in extreme detail, and you should ask for it. Take them back to the last time they experienced the problem, and ask questions that help them replay the experience. Even "what did you have for breakfast that day?" Or "how was the commute that day? Were you on time for work?" Anything to put them back there, and then they can walk you through the whole timeline of **the problem** from start to finish. (Note, it quite often starts before they think it did, too).

Just ask the question people can answer easily, and truthfully. And then ask them to replay further scenarios where the problem might have happened slightly differently. And then ask three or four more people. Not only will you then have a good handle on the problem to solve, but you'll have also heard your market describe it *in their words*, too.

### Jobs To Be Done

Another helpful approach is to analyse the *jobs people are trying to do*, or *the struggles they are having*, and not *the people themselves*. Putting people at the middle of the analysis is the more traditional approach from marketing, and is enshrined in things like Personas etc, but it can mask the problem if your not careful. So put people's jobs, or their *struggles*, front and centre - you'll still learn everything you need to know about the person when you do.

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


### How the Business Model Canvas adds a value dimension to your work


### Uncontrolled costs

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

According to GIST, how OKRs transfer into work is by organising a hierarchy with the Objective from your OKRs at the top. It proposes that each organisation should have two over-arching Key Results:

1. A "North Star Metric", which is the most-simply expressed (but accurate) measure of the overall value you're delivering to the market ("items consumed" is the example given, for a grocery supermarket).
1. A "Top Business Metric", which is intended to keep all the work everyone does viable and aligned with the business. This is usually something like "increase revenue from £1M to £1.1M" or "increase earnings from 22% to 23%".

Then its up to departments and the teams within them to come up with their own OKRs that align with those two. They can then set  Goals for the team that are based upon those.

Typically, all this should slot into a quarterly cadence, so everyone gives themselves three working months to work out the best ways to move the needles defined by their KRs and achieve good outcomes. At which point, just to keep everyone happy, you can put the planned work on an *Outcome Roadmap*; so the same sort of "this will be done by then" type plan as an Olde-Worlde-Roadmap, but with "this needle will be moved to here by 1st April", not "you will have your flying teapot by then".

The GIST hierarchy then tracks the teams' goals all the way down to sprint's worth of work for people to do.

### Lean Value Trees

On the surface, LVTs seem a very similar concept, as they are also based upon a hierarchy for transforming strategic direction and vision into actually day-jobs for people to do. However, the difference is that the hierarchy is "shifted up" one level - where GIST tracks the process all the way down, LVTs start at the level of "Vision": a "guiding direction towards which all investments should contribute", and goals come in at the next, main branch level.

So LVTs need to be implemented in cahoots with another approach to organising actual work, namely "Measures of Success", which we'll cover in more detail when we come to "Testing Hypotheses" in a bit.

The other thing about LVTs is that they're not explicitly aligned with OKRs. But I'd suggest the concept is a bit stronger than GIST when describing  *what all the levels of middle management are for*, still, once teams are generating all the ideas. The LVT concept has a lot more detail about how to *govern* these team-centric approaches, and how the "upper-echelons" should manage the "visionary" bits at the root of the tree.

Fundamentally, both approaches are about getting strategy into tactics and then on into work, though, which is quite the trick if you can pull it off. Exact levels of success will be completely affected by company culture, though, so it's worth considering both and thinking about which is more likely to fit where you are.

Generally I think I prefer GIST, though, as it fits with things that might already be going on (e.g. Scrum backlogs), so feels like it would be easier to introduce by stealth, especially if your organisation thinks that it's doing OKRs already.

### Key people and texts about focus

GIST comes from Itamar Gilad's [Evidence Guided](https://itamargilad.com/book-evidence-guided/), which clearly describes how to line OKRs up with work. It's a cracker - I'd get it if I were you.

There's a lot about Lean Value Trees in [Edge](https://www.thoughtworks.com/en-gb/insights/books/edge) and it's definitely worth diving into them for a comparison with GIST. It's similar, but perhaps more explicitly "big corporation friendly". If you haven't got time for a whole book then a) you should make some, but b) here's a [slide deck about LVTs](https://www.slideshare.net/slideshow/lean-value-tree-overview-82783795/82783795) instead.

Christina Wodtke's [Radical Focus](https://www.goodreads.com/book/show/28951428-radical-focus) is a good introduction to OKRs and it's the book that really explained the "let people change their tactics" bit to me. However, if (like me) you also enjoy a bit of schadenfreude then Kevin Mackie's Medium Article provides many ways [to do OKRs wrong](https://medium.com/@kmackie4/why-most-okrs-fail-and-the-fix-that-actually-works-47c500c91a6f), most of which are addressed by GIST and / or LVTs.

## Hypotheses and Experimentation

### The Dreaded MVP

### Discover and Deliver in the Same Process

### Confidence Levels

### Making "Bets"

### Prototyping to Learn

### Assumption Mapping

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

### Management vs Leadership

### Finance And The Digital Realm

### Is The Concept Of Value Changing
