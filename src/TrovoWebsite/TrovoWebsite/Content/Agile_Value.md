# Valuable Agility

![Article Mind Map](./images/Agile_Value.png)

## TLDR of the whole series

This is the third and final part of a three article series:

1. [The first part](Agile_WhatsThePoint.md) highlights the difference between capital-A-Agile and small-a-agility: a concept ~~stolen~~ [borrowed from Dave Thomas](https://youtu.be/a-BOSpxYJ9M?si=m5g_B7sa9_wK06cp). It also answers the question: "...does anyone remember what the original intent behind promoting agility in software engineering was?" ...with a resounding "no".
2. [The second part](Agile_AntiPatterns.md) has a lot of snarky fun pointing out everything that everyone's doing wrong. It bemoans the fact that agility is supposed to be about delivering *value*, above all else. And hardly anyone knows what that's supposed to mean - including quite a few people that society has decreed "incredibly successful".
3. This third and final part is where I finally roll up my sleeves and review some better ways of approaching agility with value at its core. Though it wouldn't be me without there being a bit of a moan at the end.

Throughout all three articles I use the phrase "Digital Realm" a lot. The [first article](Agile_WhatsThePoint.md) describes it fully, but a quick definition is: "... the place of frictionless, infinite possibility afforded by working with digital technology". Working here is usually very dangerous and most-often goes horribly wrong, but if you get *good* at working here it starts to offer some serious advantages over working in Real World ways.

## TLDR of this article

Plenty of people in the big wide world have succeeded in engineering software in small-a-agile ways, resulting in profitable and useful products. They didn't all get lucky - or at least, some of them played the percentages and vastly increased their chances of success by using strategies and tactics that:

* Used the lack of friction in the Digital Realm to their advantage, by enabling a degree of experimentation that's not possible with Real World things.
* Modelled the financial impact of their ideas and resulting products *properly*, instead of just launching stuff on a wing and a prayer.
* *Really* got to know their customers, and the things their customers go through.
* Trusted their staff to act like grown-ups with brains.
* Aligned their effort with *Products*, not *Projects*.

However - as I'm writing this in the middle\* of *the **most severe** tech bubble I can remember* (and I can remember the DotCom one), this article ends by suggesting that there might not be quite as many genuinely successful implementations of these patterns as the gurus suggest. I'm just not sure that we define "success" the right way, still - and as such *value* is still a bit problematic.

\* Actually it feels more like we're nearer the bit when it all bursts than the middle. Date of writing this: 26th August 2025 - let's see.

## Strategy and Tactics

### Viability, Feasibility and Desirability

### Deliver Value Not Features

I've built so many things throughout my engineering career that just didn't get used much, if at all. Honestly: it's been enough to make me question why I bothered in the first place. Quick answer - the salary: so I've personally benefitted tremendously from delivering little of value. The people that *paid* my salary, though - not so much.

This glorious situation is endemic within software engineering, and there's a whole cabal of gurus trying to stop it. "Deliver value, not features" is the cry, a concept which obviously ties in nicely with the [toppermost of the Agile Manifesto Principles](https://agilemanifesto.org/principles.html). These days, you may also hear the same concept described as "delivering outcomes not outputs".

Whichever way it gets styled, though, I feel this concept gets a little confusing for the average software engineer, who's job is to *build things*. And you can't really *build an outcome*, can you? You have to build *the thing that causes the outcome to occur*. I'm splitting hairs a bit here, it's not *that* complicated a concept, but nevertheless the trap of defining the problem in terms of the solution we want to build is, as ever an easy one to fall into.

So the trick is to set objectives that relate to measures of business performance, e.g.:

| The old way (outputs)             | The new way (outcomes)    |
| ----------------------------------| ------------------------- |
| Build a better checkout process   | Reduce drop-outs from the checkout from 43% to 25% |
| Create an installer               | Decrease downloads with no subsequent registration from 55% to 20% |

This theory has a name, which is...

### Objectives and Key Results (OKRs)

Intel came up with OKRs in the 80s and 90s - their CEO Andy Grove based it on Peter Drucker's business philosophy. They're all the rage now. The intention is to empower your staff by leaving the "how" of delivering objectives up to them. In the frictionless Digital Realm, there's one major advantage to this: if you prescribe a solution to the team and tell them you're going to pat them on the back if they deliver that solution, they'll go ahead and deliver it even when it's clear it won't work.

In case you missed it, "agility" means "the ability to change direction quickly". So reserving the pats and tickles for when an *outcome* is delivered encourages the team to switch tactics once it's clear the original ones aren't moving the needle. Working in the Digital Realm means there's nothing to stop you doing so, other than fear, and / or your clumsy ways of working.

That's the *theory*, anyway, but empowering teams this much is a *big cultural shift*. Managers really are in the habit of telling people what to do; even the good ones. So it takes quite a lot of willpower to let go like that. The main place I've worked that tried it didn't really get it: "we're doing OKRs now" was announced with a bit of a fanfare, but before we knew it we'd fallen back into old habits of slogging through set plans and implementing a business cases that defined solutions for us to deliver.

In other words, we weren't using the fact we were working in the Digital Realm to our advantage.

### No (Heavy) Roadmaps

GIST / LVTs - value delivery / objective centred roadmaps instead.



## Estimating value with a business model

My [PhD Literature Review](https://repository.lboro.ac.uk/articles/thesis/Does_the_way_museum_staff_define_inspiration_help_them_work_with_information_from_visitors_Social_Media_/9496598?file=17123216) suggested that epiphanies are a myth, but I came pretty close to having one of my own in 2018. I was working in Cambridge University Library at the time, and the research team I was part of had been tasked with writing a business case for two separate IT procurements. Pretty much everything we were doing was wrong - it was all very heavy on solution without having delved too much into the problems we were supposed to be solving; in fact everyone had decided what the solution was before we'd been hired, even.

However, as part of the rigmarole of getting a system in place, we had to write a business case, to a strict template which also required a business model. As I'm really not scared of looking stupid, I put my hand up in front of the chief IT Programme Manager and out-and-out asked him to explain what one of those was (I think the sentence I used started with "I know I've been in the computer programming business for 20 years already, but...")

He gave me a kind of chuckle that indicated I might not have been the first geek to have asked him this question, then showing tremendous patience, he sat me on his knee and walked me through it. This was when all sorts of things that had been brewing in my addled brain for the previous ten years or more (not least the damn PhD itself) finally clicked into place. Incidentally - this is what an "epiphany" is - there's not much mystical about it, its just the last couple of neurons between different parts of your brain making a key connection - but when it's one of those ones where the connection is *really* key, you can kind of feel it, physically.

What Chris showed me that afternoon was that is was possible to estimate the relative values of bits of an Information System in order to prioritise which one to build first. This is, of course, *the* most fundamental part of being small-a-agile, but nobody ever tells you this - you have to work it out for yourself. And try though I might throughout the following decade or so, I haven't found many other people that have been through the same "epiphany", either.

I was also shown a version of business modelling that was really, *really* slow, and based on special assumptions made by "experts" up-front. Chris did at least explain a technique where you had to note those assumptions explicitly, make them easy to change, and even Monte Carlo them if necessary, but it was all very heavyweight. Chris told me that he loved small-a-agility but that the IT function at Cambridge had made so many bad fists of implementing capital-A-Agile in the past that it was practically a swear-word in his department, so he had to do it by stealth, and given that the institution is over 800 years old, taking six months to produce a huge up-front business case is kind of being agile, anyway. But he definitely got the value bit - unlike most other people.

However, the insistence that we spend *so* long toiling away at it without, you know, *testing* any of the numerous assumptions we were working with rankled really badly with me, so I set out to find a more small-a-agile approach. Enter [the Business Model Canvas](https://www.strategyzer.com/library/the-business-model-canvas).

One thing that's always annoyed me about the Business Model Canvas is that it's not made clear enough that *you're supposed to run numbers through it*. The book Strategyzer wrote about it doesn't come out and say this outright - indeed you have to wait for Alex Osterwalder (its inventor) to get [twenty-five minutes into his key presentation about it](https://youtu.be/8GIbCg8NpBw?t=1510) before he reveals this vital point. I put this down to the barrier between business people and software engineers that I describe [in the first article](Agile_WhatsThePoint.md) - neither group understands how little the other group knows about what they do, and people with a foot in both camps are rare.

For clarity's sake: **you're supposed to run numbers through it**. Most people from Osterwalder's side of the fence know this, because it's clear from the name - it's a *Business Model* Canvas. So the two boxes at the bottom - the Cost Model and the Revenue Model, form the Cost / Benefit Analysis you'd find in a more traditional model. Indeed, you'd probably want to start building out a more traditional model you can plug *real* numbers into once your Product takes off - but the key is to *not waste time at the start over-modelling things based on really wild assumptions*. Instead, you can explore costs, benefits and the other key parts of your model *within about an hour of starting to get your idea off the ground*, instead of, er... **never** (which is the approach taken by [95% of benighted attempts at getting profitable software into the world](https://fortune.com/2025/08/18/mit-report-95-percent-generative-ai-pilots-at-companies-failing-cfo/)).

Startup culture caveat.

But the other thing that's undercooked in a lot of Product literature - COSTS!

- Value is *actually* Benefits **-** Costs. Digital systems production really struggles with this!

Need an example? How about the bubble I mentioned at the start? [Will this do](https://markets.businessinsider.com/news/stocks/ai-stocks-risk-nvidia-gpus-blackwell-tech-outlook-depreciation-accounting-2024-8)? (TLDR - if you buy $ Billions worth of GPUs in one go, when new / 'better' ones are being released all the time, then the value of your CapEx tanks a lot quicker than you're probably accounting for...)

### Hardcore experimentation

Confidence levels (ICE).

Assumption mapping.

Caveat of this bit: to experiment properly you *have to be good at experimenting*. I.e.: you should have at least an affinity with scientific methods. It's quite easy to conduct "experiments" that simply exist to confirm your biases, so an inability to at least try and remain objective about results, and failure to acknowledge that experiments that turn out exactly as expected are as rare as hens' teeth, put all the good intentions behind experimentation at risk.

Never forget: a *successful* experiment is one that turns out unexpectedly.

## Customer Discovery

NIHITO

Problem first, then solution.

The first diamond.

Investigate scenario timelines. "What do you want?" is a dangerous question, and the "Five Whys" are just rude.

### Jobs To Be Done

### Value Propositions

## Products Not Projects

Double-check from EDGE on this one

### The Dreaded MVP

### Hypotheses and Experimentation

Assumption Mapping

### Product / Market Fit

https://pmarchive.com/guide_to_startups_part4.html - but link this back to the startup culture caveat.

What is a Pivot, exactly? (Go for the Blank / Osterwalder definition).

## Team Autonomy

I've been lucky to have been mentored by two people who *really knew what they were doing*, so here's a couple of stories about them.

One of them went on holiday for a week (against his will), leaving us with a set of objectives. When he came back we'd achieved precisely zero of them. Putting on his best "I'm not angry, just disappointed" face, he gave us a choice. Option A - act like adults and work out how to get stuff done on our own - but **get it done**. Option B - give up all responsibility for progress and let him micro-manage us / treat us like children.

We were never going to choose Option B, of course, so from that point we got more productive. But the cost of being given the responsibility of solving people's problems is that you *do have to solve them*.

My other mentor watched me walk into a trap. I was a Lead Engineer at the time, so thought this gave me authority to tell people what to do. I insisted that my whole team drop what they were in the middle of and come to some *terribly important meeting or other*. To a woman / man they all told me to get stuffed. My mentor stood to one side and found the whole thing terribly amusing.

Basically, if you're hiring people who *can even cope with* being micro-managed, then your hiring policy is off. But to genuinely leave the solutions to talented people, you at least have to understand what it is they're doing, though not necessarily every detail of how they're doing it.

### Types of Team

Team Topologies

### Collaboration

"Shared OKRs"

### Decisiveness

### Product Alignment

### Self-Sufficiency

## Unfortunately, senior management need to understand all this...

There's a major change in thinking required for senior execs to let go - to become inspiring leaders instead of managerial plan-deliverers. There are engineering / CTO-Level individuals who have understood small-a-agile for long enough to represent these ideas in the boardroom, but those who represent the rest of the business are lagging behind. Hence the difficulty in adopting OKRs in a lot of companies. "I get paid my large salary to tell people what to do - if I leave it to them to decide, what am I needed for?"

The answer is leadership - but that's fundamentally different from management:

* **Management:** running the uber-strategy and plan, dropping big heavy rocks on the people below you, and keeping an eye on everyone because you don't trust them to do as good a job as you can.
* **Leadership:** keeping everyone enthusiastic and on-message by inspiring them. Trusting everyone to have the intelligence to deliver the right thing, because I've pointed them at it with clarity.

It takes a lot to step from one to the other. I quite possibly even requires people who are wired-up differently. But small-a-agile, and the ability to truly exploit the frictionless, infinite possibilities of the digital realm, only comes with the latter. As Allen Holub says, though: [this scares the pants off people](https://youtu.be/hxXmTnb3mFU?t=665).

## Has the concept of value been polluted by Venture Capital?

If the actual goal is to get to the next round of funding, or to put money in at an early stage with the aim of pulling out at a later round, but before the business has started making decent profits, well, where does this leave the concept of 'value', exactly? Small-a-agile is built upon solving the struggling moment for real customers, not telling tales of potential value - no matter how convincing they may be. When investors' cash is easy to come by, it appears that whatever passes for 'human nature' currently can tend towards the second of these, but the businesses we work for will be more sustainable, and we will better justify our salaries, by building digital products that add real value to real people, on the ground, today.

## Finance and The Digital Realm just don't mix

Computers make it far easier for people to make money by doing nothing of value at all. Evidence: 2008 - [Collatoralised Debt Obligations](https://www.investopedia.com/terms/c/cdo.asp) wouldn't exist without computers. Practices such as short-selling that completely undermine the original intention of having a stock market in the first place would arguably be a lot harder if those markets hadn't been digitised. And don't get me started on the Ponzi-scheme that is Bitcoin.