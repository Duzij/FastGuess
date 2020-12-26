<template>
<div class="picture">
    <h1>{{picture.question}}</h1>
    <img :src="picture.base64">
    <Answer
    v-for="answer of answers"
    v-bind:answer="answer"
    v-on:answer-selected="sendAnswer"
    />
    <button v-on:click="$emit('send-answer', picture.) />
</div>
</template>

<script>
export default {
    props:{
        picture:{
            type: Object,
            required: true
        }
    },
    methods:{
        sendAnswer(answerText){
            console.log(answerText)
            console.log(this)
        }
    }
}
</script>


<style>
.picture {
  background-color: antiquewhite;
}
</style>
