<template>
  <div class="picture">
    <h1>{{ picture.question }}</h1>
    <img :src="picture.base64" />
    <Answer class="answers"
      v-for="answer in picture.answers"
      v-bind:key="answer.answerText"
      v-bind:answer="answer"
      v-on:answer-selected="$emit('answer-selected', answer.answerText)"
    />
  </div>
</template>

<script>
import Answer from "@/components/Answer"
export default {
  props: {
    picture: {
      type: Object,
      required: true,
    },
  },
  components:{
    Answer
  }
};
</script>


<style>
.picture h1{
  margin: 1rem;
}

.answers{
  display: inline-flex;
  justify-content: space-around;
  flex-wrap: nowrap;
  width: 20%;
  margin: 1rem;
}
</style>
