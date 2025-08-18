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

Working in a frictionless universe of infinite possibilities means we can, and often / usually do, just **make stuff up we go along**, while kidding ourselves that we're making progress towards some goal or other. Quite often we call doing this "being Agile", when in fact it's just pure chaos and time-wasting.

We often like to justify our professional salaries while we're making stuff up, too, by card-carrying our expertise around (in the case of disfunctional programmers and designers), or waving Capital-A-Agile Scrum-Master / Product Owner certificates in people's faces and using big words from business school (in the case of disfunctional Business / Product people).

None of this provides any lower-case-a-agility, because it's highly unlikely to deliver any value, unless we get at-best-once-in-a-career lucky.

If you'd like to skip to some ways of using the frictionlessness of the Digital Realm to actually play the percentages of success better\*, check out [the next article](./Agile_Value.md). But you'll miss a lot of snarky fun if you do.

\* Well, at least *in theory*, but some of the solutions have their own issues too.

## Making stuff up as we go and calling it "Agile"

This is the predominant approach everywhere I've worked. Because there's no friction in the Digital Realm, the knee-jerk reaction is always to take the path of least resistance. One common manifestation of this is for someone senior to say "yes" whenever someone marches into their office with a bright idea / terrible problem, then immediately drive-by some underling's desk and ruin their day with it. One way to measure how deeply into this culture you are is the length of the "equal first priority list" - there's usually a couple of GREAT-BIG-IMPORTANT-THINGS that cause everyone's minds to flex dangerously, but I've worked in places where the list has been in double figures, and: "...what will I be working on today?" has been a source of constant mystery.

All the books on Agile (and small-a-agility, too, for that matter) seem to suggest the existence of organisations where this *never* happens... If so I suspect their company HQs to be nestled in the foothills of the Big Rock Candy Mountain.

### Not doing all the things

Cherry picking "the bits of Agile that suit us". See article 1 and the 12 Angry Snakes - you have to do *all the things*, because each one stops at least one of the others from biting you in the arse.

### Doing too much in one go

Taking steps that are too big, not getting feedback from the only people that can tell you for sure if something's valuable, by the way they behave, not by what they say.

(This links to pointless meetings, below).

### Working "without a design"

Hey - there *will be a design*, but if you haven't worked on it explicitly, it'll be a bad one.

### Heroism

Hero programmers who dive straight into code based upon half-muttered sentences that start "we want a...", proceed to tie themselves up in knots, but keep going anyway because they don't want to throw their valueless work away.

Ditto heroic designers who dive straight into colour theory, typeface choices, mood-boards etc - because (just like code) "design is special and you need to be talented to do it".

I'm **not** saying that neither of these endeavours require knowledge and talent. I **am** saying that all the talent in the world won't help if you don't attempt to understand the problems you're trying to solve. Indeed - amazing skill and talent makes things worse if you deploy it too early as it:

* Takes you off in the wrong direction, *away* from the better solutions.
* Sometimes makes you less objective about the facts of the case, particularly ones that contradict any hard-earned beliefs you might have built up over your glittering career.

Here's a proposal for a simple definition of heroic behaviour: "not listening to the people with the problem because I already know the answer", which extends to "bending the problem towards my solution because I've already built loads of stuff that doesn't help and I don't want to undo it". This still happens too much in software production, and its a key reason nobody uses a lot of the stuff we produce.

## Staff working at cross-purposes

### Engineers

Who exist to solve abstract problems.

Who argue about "patterns" / talk endlessly about "aggregate roots".

With Marlene Dietrich syndrome. 

Who invent "requirements".

Who act heroically.

### Designers

Who also invent requirements.

And who also act heroically.

Who obsess over little details.

Who often don't even exist?

### Product people

Who "speak for the customer" without ever going to see what they do.

Who ask the customer "what they want" and take orders like waiters.

Who lack technical confidence, and so seek to justify their existences.

## Too many meetings about nothing in particular

### Unproductive cadence

A lot of capital-A-Agile teams insist upon "ceremonies" held at regular times throughout Sprint and release cycles. I've had t work in this way and in my experience it was unproductive because it forces engineers to demonstrate work when they're not ready, or on the flipside, to wait until the next "ceremony" to demonstrate and release work that *is* ready.

Set times for demonstrations of work that isn't valuable can cause a vicious circle: customers come to a couple of demos but quickly decide they're not going to see anything useful, so stop coming. This results in less feedback to work with, resulting in even less valuable work to demonstrate next time. Pretty soon demos are being held between the team and engineers themselves, with never a customer in sight.

### Customers conspicuous by absence

### Continuous improvement as an abstract concept

When you don't have measures of:

* The value you're delivering
* The quality of your work\*

... then you'll never know whether any of the best-practices everyone encourages each other to adopt at your Sprint retrospective are *actually* helping.

\* (The latter can be hard to measure but "number of bugs you released" and "length of time taken to change direction" might be good starters?)

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

When you only do the "engineering" bits of capital A Agile in isolation of the "value bits", you get a Feature Factory.

Delivering "what the customer wants" quickly, and with high-quality code, and few mistakes, to a solid cadence. Everyone is jolly, busy and jolly busy. Story points get chewed through, and the burn-down burns down to ashes every sprint.

Nobody important *actually* cares or uses the software you deliver.

## Bad programming

### Inflexibility

### "Pointless tests"

A big part of this can be chalked down to "people not getting *all* of it. Case in point, Dave Thomas himself, who in his original "Agile is dead" talk asked the Lord Almighty to strike him down for "not doing tests because **I** already understand **my** design".

A lot of engineers agree with the whole "I know what I'm doing and my design is solid, so why do I need to test it argument", and it is superficially reasonable up to a point. But where it falls over relates to:

* Working software over *comprehensive documentation*

If you only conceive of Unit Tests as "proof my code worked when I pushed it" then you *really are missing the point*. Your tests aren't for you, today. They're for the poor bastard who, six months later, has to diagnose an issue related to the part of the codebase you changed. (**Note:** that poor bastard might also be you, though as an old boss liked to put it "it helps if you imagine they're a mad person with a pick-axe, who knows where you live").

In other words, the proof that the software worked when you left it is also the documentation people will need in the future to work out WTF it does. (They won't read your comments - so why not use all the time it takes you to write them to write tests instead? One reason is often "because I don't know how to design my code to be testable".)

If you think of Unit Tests just as "tests" and not as bits of **executable documentation** that let you step into an app with a debugger to find out how it hangs together, and how it behaves, without having to run the whole thing end-to-end, then you don't know as much about working on enterprise code-bases as you think you do.

That said - there **are** also a lot of pointless tests in the world, and measuring "quality" purely by percentage of code-coverage is another one of those "too many people in the business who don't know enough about what they're doing" things I mentioned earlier.

### Superficial knowledge in high-level engineers

There just aren't enough genuinely good software engineers in the world unfortunately.

If you're at the top of the software engineering tree, working at enterprise scale with medium sized / lots of data (anything above four or five million data points a day, say) you need to *really* understand the languages you're working with. So, for example, if you're a C# engineer, and you want to get to the top of the ladder, you need to learn how to recite C# In Depth by John Skeet, forwards and backwards. Not enough people can do this, but a lot of people do get paid *as if they can*.

One person who loves this situation is Jeff Bezos, who charges for all the unnecessary compute that results from people not having what my old boss calls "mechanical sympathy" with what the systems they're abusing actually do. So if you're pushing code to AWS without even knowing how to soak test it with a profiler running, then it's partly your fault that we all had to sit through Katy Perry going to space (nearly).

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