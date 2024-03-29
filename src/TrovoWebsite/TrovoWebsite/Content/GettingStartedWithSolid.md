# Getting Started With Solid

My PhD research had quite a lot to do with Social Media. I started it in 2012, when there was still lots of optimism about the potential for Social Media to make a positive difference to society, but there's been a whole heap of Brexit, Donald Trump and so forth since then. Indeed it was clear there was going to be a bumpy road ahead while I was researching: my thesis refers to [Zeynep Tufekci](https://zeynep.me/), [danah boyd](https://www.danah.org/), [Geert Lovink](https://networkcultures.org/geert/biography/) and a few other Social Media naysayers. Given what I'd learned from my research, I stopped using Facebook shortly after completing [my thesis](https://repository.lboro.ac.uk/articles/thesis/Does_the_way_museum_staff_define_inspiration_help_them_work_with_information_from_visitors_Social_Media_/9496598), and while I still have a Twitter account and take the odd stroll around it now and again, I don't really use it.

However, it wasn't all doom and gloom: one the things I learned was that it's not Social Media per-se that's at fault for the way things have gone, it's *the business models of the industrial Social Media companies* that are the problem. Of course, those companies don't really have 'business models' in the traditional, fuddy-duddy sense of: "doing something valuable that people want to pay for"; they run on a "get plenty of eyeballs using your platform and try to convince investors you'll be able to monetise that one day" model... So they have a major focus on the "eyeballs" part of that equation - people have to pretty much get addicted to these big platforms, or the fountain of Investment Capital runs dry, as this [Guardian long-read by Richard Seymour](https://www.theguardian.com/technology/2019/aug/23/social-media-addiction-gambling) explains. 

A crucial part of the addiction game is that nothing's going to guarantee "engagement" better than a good, old fashioned screaming match, at least in the way Social Media companies and their investors define "engagement". Genteel agreement tends to result in one "yes you're right" type post per participant, but if we all want to have the last word, well, that's when the numbers start to ramp up... 

Every post of Donald Trump's initiated a million "... no you're the asshole! No, *you're* the asshole!" backs-and-forths that Twitter and Facebook could add to their "engagement" stats, to help put some "good" numbers in front of investors. Hence Trump being allowed to go all the way up to encouraging people to attack the Capitol Building before they switched him off. This situation of arguments and dissent producing "high engagement" is not what anyone sane would call healthy, is it?

My research, therefore, concurred with many others... For Social Media to actually deliver upon early promises of "the wisdom of crowds" and "bottom-up democratic structures", it needs to be decentralised from big, industrial players. Just the concept of making an industry out of people's friendships seems wrong, doesn't it? 

Anyway, it turns out that no less a luminary than Sir Tim Berners-Lee appears to agree with this, as described here, in [another Guardian article by John Harris](https://www.theguardian.com/lifeandstyle/2021/mar/15/tim-berners-lee-we-need-social-networks-where-bad-things-happen-less). So Sir Tim has put his weight behind a technological specification for an approach called [Solid](https://solidproject.org/). The idea behind this is that people will start storing their own personal data and content in "Personal Online Data Stores", or Pods. You can then contribute this content to whichever network or application you chose, or take it back again, whenever you see fit.

Access to these Pods is controlled using open authentication and authorisation protocols (i.e. the [Solid implementation of Open Id Connect](https://solid.github.io/solid-oidc/)), and the Pod owner gets to grant and revoke access to specific bits of data / content / "stuff" in their Pod to different "agents", which would most likely be applications used by specifically-identified individuals or organisations. Those could be Social Networking Apps, though it feels like there could be plenty of other potential applications, too.

Those who have been working in the web area for a long time will know that there's nothing Sir Tim seems to like more than a meaty old specification, and true to form, Solid has a few of these that cover its various moving parts: [this one](https://solidproject.org/TR/protocol) looks like the mother. I, on the other hand, like looking at pictures, so as I'm intrigued by all this, I've done a first-pass diagram based on a very quick-and-dirty skimming of it all (mainly just reading intro stuff and the basic terminology parts so far). 



![Solid - Top-Level Bounded Contexts](images/SolidPodContexts.png)



You may also notice a bit of the terminology of [Domain-Driven Design](https://en.wikipedia.org/wiki/Domain-driven_design) (DDD) creeping into my picture (i.e. "Bounded Contexts"). This is something I'm still a bit new to but hopefully the DDD jargon doesn't really affect the info in the diagram too much. It also (intentionally) doesn't match the exact terminology of the intro to Solid, because I've tried to dial down the technical jargon at least a bit (so no URIs, Agents, Root Containers, Read and Write Operations etc etc yet - they'll come along soon enough). 

Another thing that DDD tells us is that such first pass attempts at understanding are inevitably wrong, so this picture will certainly change as I learn more. However, even at this early stage, one thing I believe could be so significant that I've coloured it blue is my feeling that Solid is kind of abstract: there's a lot of "how" one would keep one's "stuff" under control, but it's going to be easier to make sense of that, in future, by applying a bit of "why", in the contexts of "Other Domains". 

Eric Evans's [original book about DDD](https://www.abebooks.co.uk/book-search/isbn/0321125215/?cm_mmc=ggl-_-UK_ETA_DSA-_-naa-_-naa&gclid=Cj0KCQiA15yNBhDTARIsAGnwe0Un_0rHUV-jIFMqSB1SUQ4gcyDnN3AoWXnfyR9IrsRbGdQ5hJp32NkaAjEnEALw_wcB) (so significant that he coloured it blue, too) is 20 years old, now, so it discusses the Domain Model's place in a "layered architecture" in a way that seems a little dated nowadays. However, a core DDD concept is that "the Domain" is intended to be a "representation of business information", which ought to be isolated from "Presentation", "Application" and "Infrastructure" layers. Even if the "layered" way of thinking about this seems a bit clunky these days, this need to isolate "a representation of business" from the other moving parts still definitely holds true if you want to be able to make quick and timely changes to your software as new opportunities come to light.

Solid, then, looks to me like it's actually got its fingers more in the Application and Infrastructure parts of the pie, so the trick is probably going to be how to adapt it for each Domain we want to apply it to. It's highly likely that the People (i.e. Owners and Users) will have significantly different needs from Domain to Domain, too. So another question is probably:  "...how might we come up with processes to adapt Solid accordingly?" But I'm going to have to dive a lot more deeply into it before I can try to answer that.

## My main problems with Solid (so far)

The key issues I have with Solid relate to the early and copious use of the word "document" in its specification, e.g.:

**data pod**

*A data pod is a place for storing documents, with mechanisms for controlling who can access what.*

... which is the fundamental piece of terminology at the top of the [main protocol spec](https://solidproject.org/TR/protocol). Those of you that have waded through my [positioning piece on Digital Preservation](/Articles/DigipresIdeas) will know that I have a bit of a problem with the concept of *documents* when it comes to Digital Stuff; documents are, IMHO, very much part of the "Paperdigm" and thinking in those old publishing terms is too fixed, inflexible and grounded in real physicality to do justice to what makes Digital Stuff different.

Also, initially it feels as if Solid also depends too much upon ideas of *originality* that I also find problematic. Yes, you can theoretically own all the content in your Pod and control who accesses it with what applications, but at the end of the day, it's digital, so if someone can use it, then they can copy it. 

However, it's definitely an interesting idea, particularly the way in which content and identity seem to be so closely related within its underlying model. That in particular feels like its at least getting closer to the root of something good. So I shall keep chipping away at trying to understand it better.

As part of that, I've made some notes about [a couple of domains](/Articles/SolidDomains) that I think we could build a couple of good Solid applications in. 