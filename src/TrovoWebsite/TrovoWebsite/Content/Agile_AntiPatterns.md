# Agile\* Anti-Patterns

\* I'll probably moan about things that aren't strictly Capital-A-Agile too,  but it's mostly that.

This is the Mind Map of the "Agile anti-patterns" article.

![Article Mind Map](./images/Agile_AntiPatterns.png)

## TLDR of the whole series

This is part two of a set of three articles where I jump on the "Agile Is Dead, Long Live Agility" bandwagon:

1. [The first article](./Agile_WhatsThePoint.md) asks if we've forgotten that agility in software engineering was originally a defence mechanism for working in a frictionless Digital Realm of infinite possibilities (i.e.: "the Quantum Realm but with more meetings"). It also upbraids some of the computer programming fraternity (the "we hate meetings" ones, mostly) for asking to be "left alone to get on with it", while handing off the the responsibility for defining "the value of the work" to everyone else.
2. This article is going to get really snarky as I go into detail about things that are wrong with Capital-A-Agile. It's the fun article, in other words.
3. [The third article](./Agile_Value.md) dives into the concept of value, reviews some of the approaches that attempt to square the circle of small-a-agility by defining value properly, and is probably going to get a bit political.

If you're a bit confused by the Capital-A-Agile / small-a-agility distinction then it's covered [in the first one](./Agile_WhatsThePoint.md), where I also explain that I've [stolen it from Dave Thomas](https://youtu.be/a-BOSpxYJ9M?si=m5g_B7sa9_wK06cp).

## TLDR of this article

Working in a frictionless universe of infinite possibilities means we can, and often do, just **make stuff up we go along**, while kidding ourselves that we're making progress towards some goal or other. Quite often we call doing this "being Agile", when in fact it's just pure chaos and time-wasting.

We often like to justify our professional salaries while we're making stuff up, too, by card-carrying our expertise around (in the case of disfunctional programmers and designers), or waving Capital-A-Agile Scrum-Master / Product Owner certificates in people's faces and using big words from business school (in the case of disfunctional Business / Product people).

None of this provides any lower-case-a-agility, because it's highly unlikely to deliver any value, unless we get at-best-once-in-a-career lucky.

If you'd like to skip to some ways of using the frictionlessness of the Digital Realm to actually play the percentages of success better\*, check out [the next article](./Agile_Value.md). But you'll miss a lot of snarky fun if you do.

\* Well, at least *in theory*, but some of the solutions have their own issues too.

## Making stuff up as we go and calling it "Agile"

This is the predominant approach everywhere I've worked. Because there's no friction in the Digital Realm, the knee-jerk reaction is always to take the path of least resistance. One manifestation of this is for someone senior to say "yes" whenever someone marches into their office with a bright idea / terrible problem, then immediately drive-by some underling's desk and ruin their day with it. One way to measure how deeply into this culture you are is the length of the "equal first priority list" - there's usually a couple of GREAT-BIG-IMPORTANT-THINGS that cause everyone's minds to flex dangerously, but I've worked in places where the list has been in double figures, and: "...what will I be working on today?" has been a source of constant mystery.

All the books on Agile (and small-a-agility, too, for that matter) seem to suggest the existence of organisations where this *never* happens... If so I suspect their company HQs to be nestled in the foothills of the Big Rock Candy Mountain.

### Not doing all the things

If you've read about the Twelve Angry Snakes in [article one](./Agile_WhatsThePoint.md) then you already know my views on this. Cherry picking "the bits of Agile that suit us" is a terrible thing to do because each bit of the puzzle is a check and balance on at least one of the other bits. Pull any piece out and they all collapse around you.

If you ever work somewhere that says its being ["Wagile"](https://cloudcoach.com/blog/what-is-wagile-project-management/) then you might want to reflect upon your life choices. That said - a lot of places do "Agile engineering with Waterfall strategy and tactics", which is a great way of wasting time and money, and only delivering good things by accident. Lots more about that in [article three](./Agile_Value.md).

### Doing too much in one go

When you end up planning, 'refining' and building 'stuff' without regular feedback from customers (both users and buyers), then its a sure sign you're in a Capital-A-Agile world and not a small-a-agility one. Customers and buyers are the only people who can confirm the value of what you're doing.

Also, the only legitimate confirmation is in their *actions*, not what they actually say - as very often they'll know just how much effort has been put into what you're showing them, and they'll hide their misgivings just to spare your feelings.

So take the smallest possible step each time, then deploy the change somewhere you can get meaningful, measurable feedback. Chuffing your work out into some sort of demo that customers / stakeholders are forced to attend at knifepoint doesn't count. (See 'unproductive cadence' below).

### Working "without a design"

Contradictory "Agile" / "agility" alert. There's one of the 12 principles that says:

* Continuous attention to technical excellence and good design enhances agility.

...but design is still-too-often thought of as "the thing you do at the start". This means the "continuous" part of the statement gets interpreted by programmers as "it's OK to dive right into things and see where I end up", because that's what a lot them would rather do - write code in a quiet corner somewhere and solve abstract problems that are only spuriously connected to reality.

If you take the chunks of [Uncle Bob Martin](https://learning.oreilly.com/library/view/clean-code-a/9780136083238/) about writing code iteratively out of context, then you can even back yourself up a bit, though only by doing all of the "red" part of "red / green / refactor", with a little bit of "green" just to keep your manager off your back, and ignoring the "refactor" part completely because you don't know how to do it.

However - just launching into the solution without putting some concious effort into some sort of design, without applying a few decent design principles to the problem, is almost certainly going to end up in mess. Eric Evans in his [Blue Book](https://learning.oreilly.com/library/view/domain-driven-design-tackling/0321125215/) even recommends brainstorming design ideas for your solution until there's nothing left but stupid suggestions, though going this far will likely delay things.

Hey - whether you do it conciously or not, there *will be a design*, but if you haven't worked on it explicitly, it'll be a bad one, that only you will be able to change - probably by breaking other bits of it, then waiting for customers to tell you about it. Which brings us to...:

### Heroism

Do you know anyone who:

* Dives straight into code-only solutions?
* Bases these solutions on a few half-muttered sentences from one customer that started: "We want a..."?
* Ties themselves up in knots, but keeps going anyway because they don't want to admit they were wrong and throw their valueless work away?

You've got a hero programmer on your hands. I.e. someone who makes a load of trouble for themselves (and everyone else), but then swoops in to "rescue" the situation, often at 2am in response to some crisis or other. The propensity to rise up on command whatever the hour to stamp out fires means that the CEO loves this dude (it's nearly always a dude). They know how to fix *everything* (because they broke it all in the first place). They know where all the bodies are buried (because they buried them).

There's another form of the species - heroic designers. These are people who dive straight into user journeys, colour theory, mood-boards, grids, typeface choices etc - also without *really* finding out what the problems they're solving are - because (just like coding) "design is special and you need to be talented to do it" . In design terms, they [live in the second diamond](https://www.designcouncil.org.uk/our-resources/the-double-diamond/).

I'm **not** saying that complex, technical endeavours don't benefit from knowledge and talent. I **am** saying that all the talent in the world won't help if you don't attempt to understand the problems you're trying to solve. Indeed - amazing skill and talent makes things worse if you deploy it too early as it:

* Takes you off in the wrong direction, *away* from the better solutions. At which point it's *worse* than being totally useless.
* Often makes people less objective about the facts of the case, particularly ones that contradict any hard-earned beliefs built up over glittering careers. All situations are different - what you know already probably doesn't apply this time.

Heroic behaviour can be summed-up as: "not listening to the people with the problem because I already know the answer", which extends to "bending the problem towards my solution because I've already built loads of stuff that doesn't help and I don't want to undo it". This still happens too much in software production, and it's a key reason nobody uses a lot of the stuff we produce.

It's great to be talented and talented people are great to work with - provided they know how to deploy their talent properly.

## Disfunctional people and teams

Full disclosure - I am of course at least as guilty of committing the crimes listed below as anyone else. It's almost as if the frictionlessness of the infinite Digital Realm makes it easy to act in the following shameful ways.

### Engineers

* Who exist to solve abstract problems without thinking about concrete problems.
* Who argue about "patterns" / talk endlessly about obscurities like "aggregate roots" or "hexagonal architectures"\*, again without listening to the problem.
* With Marlene Dietrich syndrome: *"I want to be alone"*.
* Who invent "requirements" and implement solutions without checking their value.
* Who act heroically (see above).
* Who simply don't know how to build code-bases that are easy to change in future (I've lost count of the numbers of highly-paid engineers I've worked with who *don't know what interfaces are for*).

... will most likely march you away from anything good at a rapid pace. Eventually knowledge about the things you would have been better off doing in the first place will emerge, at which point they won't want to re-do all the stuff they've built so far. So they'll try and bend / break what they've done up to that point to better fit reality. This [causes more Technical Debt](https://youtu.be/d2Ddo8OV7ig?si=mp9oGFX-sCv4nwQ6) than any other factor.

*\ There's nothing wrong per-se about either of these concepts but there's a time and a place, you know?

### Designers

* Who also invent requirements.
* And who also act heroically.
* Who obsess over little details - e.g. moving things six pixels to the left - when they're yet to find out which market segment the product is being aimed at and what sort of customer relationships we're trying to build.
* Who often don't even exist in the first place? Designers tend to be heavily outnumbered by engineers for some reason, when both jobs take a similar amount of effort to do properly... I've never understood why this is.

Actually, while I'm ranting - what is it with UX designers and JavaScript frameworks? There's this big rabbit hole of design systems / "languages" that seems to have opened up, so now we have designers that take massive steps *away* from problems into an abstract world of components and widgets, that are intended to be all things to all product UIs. They're kind of like nuclear physicists trying to come up with a Unified Theory of Everything - only *slower*.

I guess it's the same as computer programmers that don't really understand patterns but try and apply them everywhere regarless - we're diving into abstractions without bothering to understand the problems. It always comes back to that.

### Product people

* Who "speak for the customer" without ever going to see what customers actually do.
* ... and *should* they ever go and see a customer, they go on their own, and then return with a gift-wrapped solution for designers and engineers to "just build".
* Who ask the customer "what they want" and take orders like waiters. This is where the [mis-attributed Henry Ford quote](https://medium.com/@adrianh/faster-horses-50ff8bb1bb62) about Faster Horses gets rolled out. Ask [the right question](./Agile_Value.md)!
* Who lack technical confidence, and so further seek to justify their existences by placing themselves between the customers and people who can solve their problems. Bring the technical / clever people to problem first, then at least have a vague idea what the solutions they're proposing are.
* Who cling faithfully to **"their vision"**, ignoring the industry-wide odds that one-in-three to one-in-ten "great" ideas actually make no positive difference.
* Who believe that it's possible to write a "detailed Road Map for the next 12 months". Sorry to burst your bubble but it's more than likely going to get blown out of the water by reality after about six weeks, max (though it can often only take days).

To be honest these herberts are the worst of the lot.

More than anything else, it's the Product person's job to bring the problem solvers to the problem, and help them understand it. When they interject themselves *between* problem and solvers, they do more damage than any of the other nere-do-wells I'm describing here.

### Project Managers

* Who even exist in the first place. Managing adventures in the Digital Realm like you would bridge or house-building in the Real World is a sign that you've [missed the point](./Agile_WhatsThePoint.md) at a very fundamental level.

## Projects not Products

Refer to Jim Highsmith in this bit

## Too many meetings about nothing in particular

This seems to be the thing that's really got under the skin of the programming fraternity when the phrase "Agile is Dead!" is bandied about. I believe there to be two main culprits: value-free demos and toothless retrospectives.

### Unproductive cadence

A lot of capital-A-Agile teams insist upon "ceremonies" held at regular times throughout Sprint and release cycles. I too have been made to work in this way I agree that it's unproductive. It forces engineers to demonstrate work when they're not ready, or on the flipside, to wait until the next "ceremony" to demonstrate and release work that *is* ready.

Demonstrations of work that the engineer doesn't think is ready, or that only shows a terribly important technical step towards some distant goal or other, cause a vicious circle. Customers come to a couple of demos but quickly decide they're not going to see anything that's valuable to them, so stop coming. This results in less feedback to work with, resulting in even less valuable work to demonstrate next time. Pretty soon demos are being held between the team and engineers themselves, with never a customer in sight.

### Customers conspicuous by absence

There is no better smell that you're ideas aren't fitting well with the market / user-base than people not showing up to find out more about what you're up to. Believe me, if you've landed your solution anywhere near the thing that's causing people the most pain, they'll be interested. But you have to *listen to them* and find out what their "[struggles](https://www.demandsidesales.com/)" are for this to work.

### Continuous improvement as an abstract concept

When you don't have measures of:

* The value you're delivering.
* The quality of your work.

... then you'll never know whether any of the best-practices everyone encourages each other to adopt at your Sprint retrospective are *actually* helping.

Quality can be hard to measure but "number of bugs you released" and "length of time taken to change direction" might be good starters? How about "average number of pull-request comments"? Though this can be skewed by the fella on the team who complains because Git-Commit messages don't have a full-stop on the end. (This actually happened).

Worse than all of this is the talking-shop retrospective where everyone wastes an hour moaning about all the crazy bobbins that's happened in the last two weeks, without committing to anything that would make the world a better place. I'm all for continous improvement - it's one of the two bedrocks of small-a-agility after all - but you do *have to*, you know, **improve, continously**. If you don't, then you're just holding retrospectives because *Scrum says you have to*.

## Being told what to do, how, and by when

I've been lucky to have been mentored by two people who *really knew what they were doing*, so here's a couple of stories about them.

One of them went on holiday for a week (against his will), leaving us with a set of objectives. When he came back we'd achieved precisely zero of them. Putting on his best "I'm not angry, just disappointed" face, he gave us a choice. Option A - act like adults and work out how to get stuff done on our own - but **get it done**. Option B - give up all responsibility for progress and let him micro-manage us / treat us like children.

We were never going to choose Option B, of course, so from that point we got more productive. But the cost of being given the responsibility of solving people's problems is that you *do have to solve them*.

My other mentor watched me walk into a trap. I was a Lead Engineer at the time, so thought this gave me authority to tell people what to do. I insisted that my whole team drop what they were in the middle of and come to some *terribly important meeting or other*. To a woman / man they all told me to get stuffed. My mentor stood to one side and found the whole thing terribly amusing.

Basically, if you're hiring people who *can even cope with* being micro-managed, then your hiring policy is off. But to genuinely leave the solutions to talented people, you at least have to understand what it is they're doing, though not necessarily every detail of how they're doing it.

### Expertise is hard won, unfortunately

You can't get this from a two-day certification course and a 50 question multiple-guess exam, unfortunately. But a lot of people have taken that route, and their lack of genuine confidence can manifest itself in ordering people about and imposing (often daft) solutions upon people who know better how to solve things.

Bad smell - people beating everyone with the "story-points" stick. Really bad smell - "that team delivers more points than you do" - this is a classic sign that someone got their certificate without getting the point, at all. (Story points are supposed to help teams estimate around *their* smallest unit of work - so they're specific to each team and vary completely according to the type of work that team does, and the systems / codebases they work with. If you think they're a productivity measure then you're doing a lot more harm than good).

## "Feature Factories"

When you only do the "engineering" bits of capital-A-Agile without the value bits, you get a Feature Factory.

Did I mention that [you have to do all the things](./Agile_WhatsThePoint.md)?

Feature Factories deliver "what the customer wants" quickly, and with high-quality code, and few mistakes, to a solid cadence. Everyone is jolly, busy and jolly busy. Story points get chewed through, and the burn-down burns down to ashes every sprint.

Nobody important *actually* cares or uses the software you deliver. Your revenue dries up. Often your software costs more to run and maintain than people are willing to pay for it (remember, Value = Benefits **minus** Costs).

Your runway shortens. Your company goes bust. In the good old days when Quantitative Easing meant there was a sturdy flow of freshly dreamt-up cash into Venture Capitalists pockets, you could always get another job, but I hear tell that its not so easy these days.

## Bad programming

### Inflexibility

### "Pointless tests"

Yes there are a lot of badly-written, brittle tests out there, but to use this as an excuse not to write any because "I design brilliant code", well it's another example of "people not getting *all* of it". Case in point, Dave Thomas himself, who in his original [Agile is Dead talk](https://youtu.be/a-BOSpxYJ9M?si=m5g_B7sa9_wK06cp) asked the Lord Almighty to strike him down for "not doing tests because **I** already understand **my** design".

My YouTube feed seems to suggest that there are programmers out there who agree with the whole "I know what I'm doing and my design is solid, so why do I need to test it?" argument. [This chap](https://www.youtube.com/c/theprimeagen) and [this swashbuckling hero](https://www.youtube.com/@jblow888), for example. Their protests are superficially reasonable up to a point, if you don't really understand what tests are for. But consider this small-a-agile manifesto statement:

* Working software over *comprehensive documentation*. [My emphasis].

If you *only* understand Unit Tests to be "proof my code worked when I pushed it" then you *really are missing the point*. **Your tests aren't for you, today**. They're for the poor bastard who, six months later, has to diagnose an issue related to the part of the codebase you changed. (**Note:** that poor bastard might also be you, though as an old boss liked to put it "it helps if you imagine they're a mad person with a pick-axe, who knows where you live").

In other words, the proof that the software worked when you left it is also the documentation people will need in the future to work out WTF it does. They won't read your comments - so why not use all the time it takes you to write them to write tests instead? One reason is often "because I don't know how to design my code to be testable" - in which case you should stop listening to Jonny Blow and jolly well learn.

If you think of Unit Tests just as "tests" and not as bits of **executable documentation** that let you step into an app with a debugger to find out how it hangs together, and how it behaves, without having to run the whole thing end-to-end, then you don't know as much about working in teams on enterprise code-bases as you think you do, Mr. Primeagan or whatever you're called.

Unit Tests provide a way of *documenting code* that lines up with *how engineers learn about code* - by *running it and seeing what it does*. They provide hundreds of tailored opportunities to run the code in all sorts of relevant contexts, though of course it helps if they're well-written enough to make it clear what those contexts are, and that the contexts themselves make sense. That's why you're supposed to do the "refactor" part of "red-green-refactor".

Remember - they've got a *pick-axe*, and **they know where you live**.

But to reiterate, there **are** also a lot of pointless tests in the world, and measuring "quality" purely by percentage of code-coverage is another one of those "too many people in the business who don't know enough about what they're doing" things I mentioned earlier.

### Superficial knowledge in high-level engineers

There just aren't enough genuinely good software engineers in the world unfortunately.

If you're at the top of the software engineering tree, working at enterprise scale with medium sized / lots of data (anything above four or five million data points a day, say) you need to *really* understand the languages you're working with. So, for example, if you're a C# engineer, and you want to get to the top of the ladder, you need to learn how to recite [C# In Depth](https://www.manning.com/books/c-sharp-in-depth-fourth-edition) by Jon Skeet, forwards and backwards. Not enough people can do this, but a lot of people do get paid *as if they can*. 

See also [Learning Python](https://www.manning.com/books/c-sharp-in-depth-fourth-edition) by Mark Lutz. Yes it's over 1000 pages long, but if you're a Data Scientist, it's your damn job to know this stuff, so get it read. Python in particular suffers from people muddling-through, because that's how it was designed, intentionally. But your lack of basic understanding can get *very expensive*.

Jeff Bezos loves engineers who build apps that look like they're working, but which contain fundamental, basic inefficiencies. That's because he charges real folding money for all the unnecessary compute resulting from people not having what my old boss calls "mechanical sympathy" with what the systems they're abusing *actually do*. So if you're pushing lamda code to AWS without even knowing how to soak test it with a profiler running, so you don't know how much data it's moving around and chewing through unnecessarily, and Amazon have to dim the lights to run it, then it's partly your fault that we all had to sit through Katy Perry going to space (nearly).

Imagine if Jeff's minions (or Satya Nadella's) could tweak the "vibe-coding" algorithms so that even more expensive-to-run code was produced... Oh my! It would be a license to print money, wouldn't it? But I've promised myself not to go near AI in this article because that will be an even bigger rant than this one.

## Is this all the fault of Scrum?

### Superficial knowledge in everybody else, too

Digital systems production is just hard. My old boss used to say "it's not a magic bullet" - just because it can be made to work, it doesn't make it easy. So it's not only the engineers that need to know their stuff, everybody does, including those in senior management.

### There's nothing too offensive in the Scrum Guide

Allen Holub says this. He also describes Scrum as "things that make 'Agile' palatable to management, without actually being agile".

So the issue there is "management" - and that's how we end the final article.

### It's just certification that's the issue

Too many people in software who don't have the deeper understanding of it required to do it properly.

I'm not saying this to exclude people - everyone can learn. But you do have to learn. Software engineering, production and design are professions, and as such they're well paid. But you have to earn that salary. If you're in those professions and you don't spend time and money on your own personal development, then you'll be actively doing harm to the organisations you work for and the people you work with.

## Unknown (but spiralling) costs

### Value = Benefits MINUS Costs

Just like everything has a design, ditto with business models. You may not have thought about the costs and benefits of your endeavour explicitly, instead chosing to launch straight into coding and design, and make stuff up as you go.  But guess what? Your project / product is still going to make or lose money, regardless. However, if you *haven't* put any thought and effort into modelling the changes you make, then there's a much greater chance that it won't make money, or if to does, that margins will be slim.

This can't ever just be a "Product thing", either. Yes, Product people are probably the best owners of business models, but Designers and (in particular) Engineers can't be let off the hook, for the costs if nothing else. As just mentioned above, in our cloud-computing world, runnng sub-optimal code eats into margins in the form of unnecessary operating costs.

## Agile engineering with waterfall product

Did I mention having to do *all the things*? I believe I did. That includes strategising, and getting tactical, in small-a-agile ways. This is what the next article is about, and there's a growing body of literature / help / advice about it.