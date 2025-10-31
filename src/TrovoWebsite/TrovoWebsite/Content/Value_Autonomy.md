# Autonomy and Empowerment

I've been lucky to have been mentored by two people who *really knew what they were doing*, so here's a couple of stories about them.

One of them went on holiday for a week - against his will - he's a "live to work" kind of guy. He left us with a pretty clear set of objectives, but when he came back we'd achieved precisely zero of them. Putting on his best "I'm not angry, just disappointed" face, he gave us a choice. Option A - act like adults and work out how to get stuff done on our own - but **get it done**. Option B - give up all responsibility for progress and let him micro-manage us / treat us like children.

We were never going to choose Option B, of course, so from that point we got more productive. But this was where I learned that the cost of being given the responsibility of solving people's problems is that you *do actually have to solve them*.

My other mentor watched me walk into a trap. I was a Lead Engineer at the time, so thought this gave me authority to *tell people what to do*. LoL. I insisted that my whole team drop what they were in the middle of doing and come to some *terribly important meeting or other*. To a woman / man they all told me to get stuffed, while my mentor stood to one side and found the whole thing terribly amusing.

This taught me that, basically, if you're hiring people who *can even cope with* being micro-managed, then your hiring policy is off. Or, as per the quote from Steve Jobs in [article 2](./Agile_AntiPatterns.md) - who on earth hires clever people and then orders them about? Marty Cagan wrote a whole other book about this - [Empowered](https://www.svpg.com/books/empowered-ordinary-people-extraordinary-products/), which makes the sensible point that running around looking for "10x" people is the wrong answer - instead give "ordinary" people the space to become "10x". Or, in a nutshell - there are no "ordinary people" - everyone's got "it" if you give them the space to work it out.

One of the key pitfalls of gallivanting around looking for "10x" people is that, unless you're a bit "10x" yourself (or perhaps 9.47628x might do, if you can't get to the full 10), there's a good chance you'll end up working with a load of demented extroverts who *think* they're 10x, but who in fact haven't got a Scooby-Do what they're on with. These are *the least likely kind of people* to produce anything good.

So, if you're genuinely going to be able to empower talented people to solve things, you at least have to understand what it is they're doing, though not necessarily every detail of how they're doing it. Marty Cagan also makes this point, by stating, bluntly, that *Product people should learn how to program computers*.

The fact remains, however, that talented people work most productively if they're allowed the space in which to be talented. This leads to the topic of team "empowerment", or even "autonomy".

## Alignment with value

In [article 2](./Agile_AntiPatterns.md) I expressed some dissatisfaction with Domain-Driven Design as a candidate for enabling teams to stop treading on each-other's toes and blocking each other. A more effective approach to team autonomy, at least if you understand your business model and know your customers thoroughly, is to align the teams up with the value they're delivering, and not DDD's "sub-domains" (which are very hard to work out).

But what of the people who manage the network, I hear you cry? Or the people who manage and maintain the supply chain? They don't go anywhere near *customers*, so how can they deliver value? If you did cry this, you're a little off the mark. Those who work on "internal", non-"customer-facing" systems still have customers, it's just that their customers are *internal-to-the-business*, their "markets" consist of their colleagues.

It's pretty simple, really - so simple that it was quite hard for everyone to spot for 15 years. You can't "deliver *valuable* software" (as per Manifesto Principle No. 1) unless you have *customers*. It has to be valuable *to someone*. So you can't *ever* be small-a-agile *if you don't have a customer*. Organise your "domains" around value delivered, even if it's "internal value" and you at least have a chance of getting some sort of agility together. This is easier if you just call your "domains" *products*, because the easiest way to define a "product" is *something with a customer*, that's *a mechanism for delivering value to them*.

So to tie all this in with concepts introduced earlier, I'd suggest that each team should have at least one Business Model Canvas that they own and maintain. They could perhaps even have a few, though if they do have more than one, their Customer Segments and Customer Relationships sections, and hence the customers in the middle of their Value Propositions, should be pretty similar. Basically, if you define the team in terms of "who they deliver value to" then you won't go far wrong.

## Types of Team

Another dimension that affects teams' productivity is the type of work they're doing, of course. This is not something that there's a cookie-cutter solution for, obviously, but a few people have made some potentially useful generalisations about it\*.

\* Not least Marty Cagan, in his book [Empowered](https://www.svpg.com/books/empowered-ordinary-people-extraordinary-products/), though there's also a whole chapter about it in [Edge](https://www.thoughtworks.com/en-gb/insights/books/edge) and a whole book about it called [Team Topologies](https://teamtopologies.com/).

The Team Topologies book recommends a fairly narrow set of team categories:

1. *Stream-aligned teams*: who are explicitly aligned with "parts of the business domain".
2. *Enabling teams*: who exist to help the stream-aligned ones "overcome obstacles". (So a good mapping to the "teams with internal customers" idea).
3. *Complicated sub-system teams*: who are the in-house experts in the most weird and wonderful pieces of tech that your organisation has to deal with, i.e. the bits that the other engineering teams don't have the specialist skills to work with.
4. *Platform teams*: the teams that understand and manage the kit that everything else depends upon, e.g. databases, streaming data systems, or containerisation.

I think this is a very *engineer-led* method of categorisation: we can tell this from the way some Domain-Driven Design terminology has started to creep in. But at least some of the "nine principles" of Team Topologies align well with small-a-agility (most obviously: "make changes small and safe", and "foster continuous discovery"), so generally its heart is in the right place. If it took the one major step of re-aligning itself with the *delivery of value to customers* rather than *parts of the business domain* then it would be bob-on.

This is where Marty Cagan's interpretation helps. He suggests three "optimisations for empowerment" to consider when organising teams:

1. *Ownership*: giving each team a set of obvious, meaningful responsibilities that they can feel motivated and enthusiastic about.
2. *Autonomy*: actually giving the team the agency to make meaningful changes. He suggests this can often get confused with "isolating the team", but admits this isn't ever fully possible. So instead what it *should* mean is "trusting the decisions that the team makes to deliver on the required outcomes".
3. *Alignment*: which he considers has two sub-dimensions - alignment with architecture (i.e. "technical alignment") and "alignment with the business"; with different business units, customer segments, value propositions, etc.

It would be the job of the chiefs of Product, Engineering, and Design to get into the weeds of organising teams in alignment with these three dimensions.

Marty further suggests a broader categorisation of team types: *Platform Teams* and *Experience Teams*. There are some similarities with the "platform" and "stream-aligned" teams from Team Topologies (which he references), but when it comes to "experience", there's a much more explicit alignment with *value delivery*. Again, he sub-divides the experience category into *customer-facing* and *customer-enabling*, but states that each of these team types is responsible for "solutions and journeys" that deliver value. By his own token, each team of this type should be considering the three constituent parts of value delivery: Feasibility, Usability / Desirability and Viability - at all times. The core difference is that "enabling" teams have internal customers.

As small-a-agility is impossible without customers (you have to deliver value to someone), I'd tend to go a step further here, and include Platform teams in the mix of needing to be aligned with the delivery of value to customers. In their case, those customers are the organisations' "other engineers" and "technical operations", but they're *still customers*. There's a whole field of "DevEx" (Developer Experience) touted by the likes of Atlassian, AWS and Microsoft, that backs me up here. So in other words, if your platform team doesn't have the same "three-amigos" structure of Product, Engineering and Design as all the other teams, your productivity is going to suffer. In this case, it'll suffer a lot, too, as a platform that's hard to use reduces the productivity of all the other teams.

Edge suggests yet another organisational model for team empowerment, suggesting that "portfolio teams" align themselves with the organisation's Lean Value Tree. If this can be achieved, then you ought to end up with a set of teams that are very well aligned with organisational goals. Highsmith et al suggest a "fractal" approach, with autonomous teams aligned with each part of the tree hierarchy; hence the executive team aligns with goals and vision, something like the "chief level" described by Marty Cagan would align with "Bets" (i.e., aligning the delivery teams with streams of value that are in service to the goals), and then the delivery teams themselves would align with initiatives at the coal-face.

Edge also suggests that the shift in perspective from "command and control" to "consultation and empowerment" can be supported by shifting the Project or Portfolio Management Office to become a "Value Realisation Team", that coaches, mentors and offers a sounding-board for decisions all the way up and down the Lean Value Tree hierarchy. One of the key activities of this team would be to help teams assess whether their "Bets" are coming off or not - i.e. should work continue on a particular approach to delivering a goal, or is it time to admit that it ain't going to work?

## Self-Sufficiency

I may have mentioned that to be small-a-agile requires "doing all the things" a few times. Team self-sufficiency is another place where the importance of that is evident. The issue here hangs on this one of the [12 Angry Snakes](https://agilemanifesto.org/principles.html):

* Continuous attention to technical excellence and good design enhances agility.

Making your software engineering teams autonomous is all well and good, but there a few things that those teams need to do to preserve their autonomy properly, and by doing so, provide everyone with software that not only works, but is *easy and quick to change*.This doesn't just mean "quick to deploy thanks to some hifalutin' Continuous Delivery build pipeline", it also means genuinely easy to change without breaking everything else around it. Software that can't be changed independently of all the other teams is one of the biggest spanners in the works you'll find.  

Key to this are five interlinked concepts that, really, not enough software engineers know enough about:

1. Modularity.
2. Cohesion.
3. Separation of concerns.
4. Encapsulation (or "information hiding").
5. Loose coupling.

These are five little angry snakelets that have hatched from the original 12, and if you're working with an engineering team that understands them, and (please dear lord) *architects* that understand them, there *might* be a cat-in-hell's chance that you'll get software delivered quickly.

All of this is described much better than I ever could in Dave Farley's [Modern Software Engineering](https://learning.oreilly.com/library/view/modern-software-engineering/9780137314942/), which I would encourage not only all software engineers to read (it should be compulsory for them to read it, tbh) - but anyone else who has to work with the blighters, too. As a basic test, if your "10x" chief engineers look at you blankly when you mention "separation of concerns" to them, then that's a good clue that they might not be as "10x" as they think. Indeed they might not even be 0.1x at that point.

## Collaboration

So here's the bad news - complete autonomy is a pipe-dream, really. Even if you've got your delivery teams nicely aligned with the value they're delivering, and they've properly-isolated the work they do, and the data they manage, etc, you're still going to need to orchestrate their work and allow them to collaborate with each other. This is where Objectives and Key Results really come into their own, or at least if senior management understand them properly. (If they do, they should be called "leadership", really, not "management").

If you're "doing OKRs" effectively, the head honchos should have clearly-articulated the top level objectives for *the whole organisation*, and lined everybody up to focus on them. This is what then allows teams to collaborate better - if we *all* know that the focus of our work for the next year is to increase company earnings from 22% to 27%, then that's the lever we can pull when we need another team to schedule in some changes to the API that provides access to the extra data we require to make our impact, but which they own.

Itamar Gilad calls this approach "sharing OKRs". If increased earnings are the objective, and the "downstream" team that needs a change have convincing evidence that the change they need the "upstream" team to make has high-enough Impact, and will move the earnings needle significantly, then it helps the upstream team prioritise a lot easier. But they can't really do that if they don't have the overarching "earnings" objective to focus on. A common phrase for this objective is the "North Star", that everyone can see and align towards.

It then becomes the job of senior and upper-middle ~~management~~ leadership to review the estimates people are making, check their evidence and confidence levels, and arbitrate between teams where necessary. Organisations that have got these sorts of processes working properly seem to have settled on a quarterly cadence, re-evaluating objectives every three months or so. They also manage "trees" of sub-Objectives that align with the North-Star one, too.

As mentioned, planning is easier if "upstream" teams think of the "downstream" ones as "their customers", too.
