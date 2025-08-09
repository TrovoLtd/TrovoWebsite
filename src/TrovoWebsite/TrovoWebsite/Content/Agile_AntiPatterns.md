# Agile Anti-Patterns \*

\* Not only but mostly

## TLDR

Because we're working in a frictionless universe of infinite possibilities, you can just make stuff up as you go along, while kidding yourselves that you're making progress towards some goal or other.

If you'd like to justify your professional salary while you're doing that, you can either card-carry your expertise around (in the case of disfunctional programmers and designers), or wave your capital A Agile certificates around and use big words from business school (in the case of disfunctional Product people).

None of this is agile (lower case a), because it's highly unlikely to deliver any value, unless you get once-in-a-career lucky.

If you'd like to skip the detail and find out how to do a much better job, check out the next article, but you'll miss a lot of snarky fun.

## Making stuff up as you go along and calling it "Agile"

### Not doing all the things

Cherry picking "the bits of Agile that suit us". See article 1 and the 12 Angry Snakes - you have to do *all the things*, because each one stops at least one of the others from biting you in the arse. 

### Doing too much in one go

Taking steps that are too big, not getting feedback from the only people that can tell you for sure if something's valuable, by the way they behave, not by what they say.

(This links to pointless meetings, below).

### Working "without a design"

Hey - there *will be a design*, but if you haven't worked on it explicitly, it'll be a bad one.

### Heroism

Hero programmers who dive straight into code based upon half-muttered sentences that start "we want a...", proceed to tie themselves up in knots, but keep going anyway because they don't want to throw their valueless work away.

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

### Pointless cadence

### Customers conspicuous by absence

### Continuous improvement as an abstract concept

When you don't have measures of: 

* The value you're delivering
* The quality of your work\*

... then you'll never know whether any of the best-practices everyone encourages each other to adopt at your Sprint retrospective are *actually* helping.

\* (The latter can be hard to measure but "number of bugs you released" and "length of time taken to change direction" might be good starters?)

## Being told what to do, how, and by when

Tell the other "John" story here. And the Duncan one.

Basically, if you're hiring people who *can even cope with* being micro-managed, then your hiring policy is off. But to genuinely leave the solutions to talented people, you at least have to understand what it is they're doing, if not every detail of how they're doing it. 

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

* Working software over comprehensive documentation

If you only conceive of Unit Tests as "proof my code worked when I pushed it" then you *really are missing the point*. Your tests aren't for you, today. They're for the poor bastard who, six months later, has to diagnose an issue related to the part of the codebase you changed. (**Note:** that poor bastard might also be you, though as an old boss liked to put it "it helps if you imagine they're a mad person with a pick-axe, who knows where you live").

If you think of Unit Tests just as "tests" and not as bits of **executable documentation** that let you step into an app with a debugger to find out how it hangs together, and how it behaves, without having to run the whole thing end-to-end, then you don't know as much about working on enterprise code-bases as you think you do.

That said - there **are** also a lot of pointless tests in the world, and measuring "quality" purely by percentage of code-coverage is another one of those "too many people in the business who don't know enough about what they're doing" things I mentioned earlier.

### Superficial knowledge in high-level engineers

There just aren't enough genuinely good software engineers in the world unfortunately.

If you're at the top of the software engineering tree, working at enterprise scale with medium sized / lots of data (anything above four or five million data points a day, say) you need to *really* understand the languages you're working with. So, for example, if you're a C# engineer, and you want to get to the top of the ladder, you need to learn how to recite C# In Depth by John Skeet backwards. Not enough people can.

One person who loves this is Jeff Bezos, who charges for all the unnecessary compute that results from people not having what my old boss calls "mechanical sympathy" with what the systems they're abusing actually do. If you're pushing code to AWS without even knowing how to use a profiler, then it's partly your fault that we all had to sit through Katy Perry going to space (nearly).

See also...

## Unknown (but spiralling) costs

## Is this all the fault of Scrum?
